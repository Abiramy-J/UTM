using System.Data.SQLite;
using UnicomTicManagementSystem.Repositories;
using UnicomTicManagementSystem.Views;

namespace UnicomTicManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Run the database migrations to create all necessary tables if they don't exist
            Migration.RunMigrations();

           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var conn = DbConfig.GetConnection())
            {
                conn.Open();

                // Seed default courses and subjects if empty
                SystemDefaults.SeedDefaultCoursesAndSubjects(conn);

                //// Check if any admin user exists
                string checkAdminQuery = "SELECT COUNT(*) FROM Users WHERE Role = 'Admin'";
                using var cmd = new SQLiteCommand(checkAdminQuery, conn);
                long adminCount = (long)cmd.ExecuteScalar();

                if (adminCount == 0)
                {
                    // No admin exists ? open first-time admin setup
                    Application.Run(new FirstAdminSignupForm());
                }
                else
                {
                    // Admin exists ? open normal login
                    Application.Run(new LoginForm());
                }
            }
        }
    }
}