using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Top_Down_Space_Shooter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Create game assets if they don't exist
            CreateGameAssetsIfNeeded();
            
            Application.Run(new Form1());
        }
        
        private static void CreateGameAssetsIfNeeded()
        {
            string[] assetFiles = { "player_ship.png", "enemy_ship.png", "player_bullet.png", "enemy_bullet.png" };
            string outputDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            
            bool needsCreation = false;
            foreach (string asset in assetFiles)
            {
                if (!File.Exists(Path.Combine(outputDir, asset)))
                {
                    needsCreation = true;
                    break;
                }
            }
            
            if (needsCreation)
            {
                CreateGameAssets(outputDir);
            }
        }
        
        private static void CreateGameAssets(string outputDir)
        {
            try
            {
                // Create player rocket ship (blue rocket pointing up)
                using (Bitmap playerShip = new Bitmap(50, 50))
                using (Graphics g = Graphics.FromImage(playerShip))
                {
                    g.Clear(Color.Transparent);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    
                    // Main rocket body
                    Point[] rocketBody = {
                        new Point(25, 5),   // Top point
                        new Point(20, 15),  // Left side
                        new Point(20, 35),  // Left bottom
                        new Point(30, 35),  // Right bottom
                        new Point(30, 15)   // Right side
                    };
                    g.FillPolygon(Brushes.LightBlue, rocketBody);
                    g.DrawPolygon(Pens.DarkBlue, rocketBody);
                    
                    // Rocket fins
                    Point[] leftFin = {
                        new Point(20, 25),
                        new Point(15, 30),
                        new Point(20, 35)
                    };
                    Point[] rightFin = {
                        new Point(30, 25),
                        new Point(35, 30),
                        new Point(30, 35)
                    };
                    g.FillPolygon(Brushes.DarkBlue, leftFin);
                    g.FillPolygon(Brushes.DarkBlue, rightFin);
                    
                    // Rocket window
                    g.FillEllipse(Brushes.White, 22, 10, 6, 6);
                    g.DrawEllipse(Pens.DarkBlue, 22, 10, 6, 6);
                    
                    playerShip.Save(Path.Combine(outputDir, "player_ship.png"), ImageFormat.Png);
                }

                // Create enemy rocket ship (red rocket pointing down)
                using (Bitmap enemyShip = new Bitmap(50, 50))
                using (Graphics g = Graphics.FromImage(enemyShip))
                {
                    g.Clear(Color.Transparent);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    
                    // Main rocket body (pointing down)
                    Point[] rocketBody = {
                        new Point(25, 45),  // Bottom point
                        new Point(20, 35),  // Left side
                        new Point(20, 15),  // Left top
                        new Point(30, 15),  // Right top
                        new Point(30, 35)   // Right side
                    };
                    g.FillPolygon(Brushes.LightCoral, rocketBody);
                    g.DrawPolygon(Pens.DarkRed, rocketBody);
                    
                    // Rocket fins (at top)
                    Point[] leftFin = {
                        new Point(20, 25),
                        new Point(15, 20),
                        new Point(20, 15)
                    };
                    Point[] rightFin = {
                        new Point(30, 25),
                        new Point(35, 20),
                        new Point(30, 15)
                    };
                    g.FillPolygon(Brushes.DarkRed, leftFin);
                    g.FillPolygon(Brushes.DarkRed, rightFin);
                    
                    // Rocket window
                    g.FillEllipse(Brushes.White, 22, 34, 6, 6);
                    g.DrawEllipse(Pens.DarkRed, 22, 34, 6, 6);
                    
                    enemyShip.Save(Path.Combine(outputDir, "enemy_ship.png"), ImageFormat.Png);
                }

                // Create player bullet (rocket bullet pointing up)
                using (Bitmap playerBullet = new Bitmap(10, 20))
                using (Graphics g = Graphics.FromImage(playerBullet))
                {
                    g.Clear(Color.Transparent);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    
                    // Bullet body
                    Point[] bulletBody = {
                        new Point(5, 2),    // Top point
                        new Point(3, 8),    // Left side
                        new Point(3, 18),   // Left bottom
                        new Point(7, 18),   // Right bottom
                        new Point(7, 8)     // Right side
                    };
                    g.FillPolygon(Brushes.Gold, bulletBody);
                    g.DrawPolygon(Pens.Orange, bulletBody);
                    
                    // Bullet fins
                    Point[] leftFin = {
                        new Point(3, 12),
                        new Point(1, 15),
                        new Point(3, 18)
                    };
                    Point[] rightFin = {
                        new Point(7, 12),
                        new Point(9, 15),
                        new Point(7, 18)
                    };
                    g.FillPolygon(Brushes.Orange, leftFin);
                    g.FillPolygon(Brushes.Orange, rightFin);
                    
                    playerBullet.Save(Path.Combine(outputDir, "player_bullet.png"), ImageFormat.Png);
                }

                // Create enemy bullet (rocket bullet pointing down)
                using (Bitmap enemyBullet = new Bitmap(10, 20))
                using (Graphics g = Graphics.FromImage(enemyBullet))
                {
                    g.Clear(Color.Transparent);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    
                    // Bullet body (pointing down)
                    Point[] bulletBody = {
                        new Point(5, 18),   // Bottom point
                        new Point(3, 12),   // Left side
                        new Point(3, 2),    // Left top
                        new Point(7, 2),    // Right top
                        new Point(7, 12)    // Right side
                    };
                    g.FillPolygon(Brushes.OrangeRed, bulletBody);
                    g.DrawPolygon(Pens.DarkOrange, bulletBody);
                    
                    // Bullet fins (at top)
                    Point[] leftFin = {
                        new Point(3, 8),
                        new Point(1, 5),
                        new Point(3, 2)
                    };
                    Point[] rightFin = {
                        new Point(7, 8),
                        new Point(9, 5),
                        new Point(7, 2)
                    };
                    g.FillPolygon(Brushes.DarkOrange, leftFin);
                    g.FillPolygon(Brushes.DarkOrange, rightFin);
                    
                    enemyBullet.Save(Path.Combine(outputDir, "enemy_bullet.png"), ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not create game assets: {ex.Message}", "Asset Creation Error");
            }
        }
    }
}