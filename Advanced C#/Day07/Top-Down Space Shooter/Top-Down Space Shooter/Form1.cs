using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Top_Down_Space_Shooter
{
    public partial class Form1 : Form
    {
        private Player player;
        private List<Enemy> enemies = new List<Enemy>();
        private List<Bullet> playerBullets = new List<Bullet>();
        private List<Bullet> enemyBullets = new List<Bullet>();
        private bool moveLeft, moveRight, shoot;
        private int score = 0;
        private int enemySpawnCounter = 0;
        private Random rnd = new Random();
        private Image playerShipImage, enemyShipImage, playerBulletImage, enemyBulletImage;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Prevents flickering for smoother graphics
            LoadAssets();
            SetupGame();
        }

        private void LoadAssets()
        {
            try
            {
                playerShipImage = Image.FromFile("player_ship.png");
                enemyShipImage = Image.FromFile("enemy_ship.png");
                playerBulletImage = Image.FromFile("player_bullet.png");
                enemyBulletImage = Image.FromFile("enemy_bullet.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load game assets: {ex.Message}\nMake sure image files are in the bin/Debug folder.", "Asset Error");
                Application.Exit();
            }
        }

        private void SetupGame()
        {
            player = new Player(gameCanvas.Width / 2 - 25, gameCanvas.Height - 70, 50, 50, 8, playerShipImage);
            enemies.Clear();
            playerBullets.Clear();
            enemyBullets.Clear();
            score = 0;
            moveLeft = false;
            moveRight = false;
            shoot = false;
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            UpdateGameLogic();
            gameCanvas.Invalidate(); // Redraws the screen
        }

        private void UpdateGameLogic()
        {
            // Update player position
            if (moveLeft && player.X > 0) player.X -= player.Speed;
            if (moveRight && player.X + player.Width < gameCanvas.Width) player.X += player.Speed;

            // Handle player shooting
            if (shoot)
            {
                playerBullets.Add(new Bullet(player.X + player.Width / 2 - 5, player.Y, 10, 20, 12));
                shoot = false;
            }

            // Update bullet positions
            playerBullets.ForEach(b => b.Y -= b.Speed);
            enemyBullets.ForEach(b => b.Y += b.Speed);

            // Spawn new enemies periodically
            SpawnEnemies();

            // Update enemy positions and handle their shooting
            foreach (var enemy in enemies)
            {
                enemy.Y += enemy.Speed;
                if (rnd.Next(0, 150) == 1) // Each enemy has a small chance to shoot
                {
                    enemyBullets.Add(new Bullet(enemy.X + enemy.Width / 2 - 5, enemy.Y + enemy.Height, 10, 20, 6));
                }
            }

            CheckCollisions();

            // Clean up objects that are no longer active or on screen
            playerBullets.RemoveAll(b => !b.IsActive || b.Y < 0);
            enemyBullets.RemoveAll(b => !b.IsActive || b.Y > gameCanvas.Height);
            enemies.RemoveAll(e => !e.IsAlive || e.Y > gameCanvas.Height);
        }

        private void SpawnEnemies()
        {
            enemySpawnCounter++;
            if (enemySpawnCounter > 40)
            {
                int x = rnd.Next(0, gameCanvas.Width - 50);
                int speed = rnd.Next(3, 7);
                enemies.Add(new Enemy(x, -50, 50, 50, speed, enemyShipImage));
                enemySpawnCounter = 0;
            }
        }

        private void CheckCollisions()
        {
            // Check player bullets against enemies
            foreach (var bullet in playerBullets)
            {
                foreach (var enemy in enemies)
                {
                    if (bullet.IsActive && enemy.IsAlive && bullet.GetBounds().IntersectsWith(enemy.GetBounds()))
                    {
                        score += 10;
                        bullet.IsActive = false;
                        enemy.IsAlive = false;
                    }
                }
            }

            // Check if player is hit
            if (!player.IsAlive) return; // Don't check collisions if player is already hit in this frame

            Action handleGameOver = () =>
            {
                player.IsAlive = false;
                gameTimer.Stop();
                MessageBox.Show($"Game Over! Your final score is: {score}", "Game Over");
                SetupGame();
            };

            foreach (var bullet in enemyBullets)
            {
                if (bullet.IsActive && player.GetBounds().IntersectsWith(bullet.GetBounds())) { handleGameOver(); return; }
            }
            foreach (var enemy in enemies)
            {
                if (enemy.IsAlive && player.GetBounds().IntersectsWith(enemy.GetBounds())) { handleGameOver(); return; }
            }
        }

        private void gameCanvas_Paint(object sender, PaintEventArgs e)
        {
            // THIS IS THE FIX: If the player object is not created yet, do not draw anything.
            if (player == null) return;

            Graphics g = e.Graphics;
            
            // Draw space background
            g.Clear(Color.Black);
            
            // Add some stars for space effect
            Random starRnd = new Random(123); // Fixed seed for consistent stars
            for (int i = 0; i < 50; i++)
            {
                int x = starRnd.Next(0, gameCanvas.Width);
                int y = starRnd.Next(0, gameCanvas.Height);
                g.FillEllipse(Brushes.White, x, y, 1, 1);
            }

            if (player.IsAlive)
                g.DrawImage(player.PlayerImage, player.GetBounds());

            foreach (var bullet in playerBullets) g.DrawImage(playerBulletImage, bullet.GetBounds());
            foreach (var bullet in enemyBullets) g.DrawImage(enemyBulletImage, bullet.GetBounds());
            foreach (var enemy in enemies) g.DrawImage(enemy.EnemyImage, enemy.GetBounds());

            // Draw score with better styling
            g.DrawString($"Score: {score}", new Font("Arial", 16, FontStyle.Bold), Brushes.Yellow, 10, 10);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) moveLeft = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) moveRight = true;
            if (e.KeyCode == Keys.Space) shoot = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) moveLeft = false;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) moveRight = false;
        }
    }
}