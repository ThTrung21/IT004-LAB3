namespace Bai01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form form = new Form();
            form.Text = "Form Properties";
            form.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            form.Width = 500;
            form.Height = 200;
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.MaximizeBox = false;
            form.Cursor = Cursors.Cross;
            form.StartPosition = FormStartPosition.WindowsDefaultLocation;
            Application.Run(form);
        }
    }
}