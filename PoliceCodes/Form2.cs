using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceCodes
{
    public partial class Form2 : Form
    {
 
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public Form2()
        {
            this.InitializeComponent();


            List<Label> labels = new List<Label>();
            Font LargeFont = new Font("Segoe UI", 11, FontStyle.Bold);

            int counter = 0;
            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines("./codes.txt"))
            {
                Label namelabel = new Label();

                if (counter % 2 == 0)
                    namelabel.ForeColor = Color.Cyan;
                else
                    namelabel.ForeColor = Color.LightGreen;

                namelabel.Location = new Point(3, 20 + (counter * 18));
                namelabel.Name = line;
                namelabel.Text = line;
                namelabel.AutoSize = true;
                namelabel.Font = LargeFont;
                labels.Add(namelabel);

                counter++;
            }

            foreach (Label label in labels)
            {
                Controls.Add(label);
            }
        }

        // Token: 0x06000002 RID: 2
        [DllImport("user32.dll")]
        public static extern short GetKeyState(int keyCode);

        // Token: 0x06000003 RID: 3
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        // Token: 0x06000004 RID: 4
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        // Token: 0x17000001 RID: 1
        // (get) Token: 0x06000005 RID: 5 RVA: 0x00002065 File Offset: 0x00000265
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 128;
                return createParams;
            }
        }

        // Token: 0x06000006 RID: 6 RVA: 0x00002080 File Offset: 0x00000280
        private void Form2_Load(object sender, EventArgs e)
        {
            int windowLong = Form2.GetWindowLong(base.Handle, -20);
            Form2.SetWindowLong(base.Handle, -20, windowLong | 524288 | 32);
            Console.WriteLine("Tlačítko: Insert -> Zobrazí/schová tabulku s kódy.");
            Console.WriteLine("\nProgram vypneš tak, že zavřeš tuhle konzoli.\n\n");
            base.Left = 0;
            base.Top = 0;
            base.TopMost = true;
            base.Opacity = 0.85;
            this.Height = Screen.PrimaryScreen.Bounds.Height - 50;
            this.timer1.Interval = 25;
            this.timer1.Start();

        }

        // Token: 0x04000001 RID: 1
        public bool pressed;

        // Token: 0x04000002 RID: 2
        public bool show = true;

        // Token: 0x04000003 RID: 3
        private const int GWL_EXSTYLE = -20;

        // Token: 0x04000004 RID: 4
        private const int WS_EX_LAYERED = 524288;

        // Token: 0x04000005 RID: 5
        private const int WS_EX_TRANSPARENT = 32;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Form2.GetKeyState(Convert.ToInt32(VK.INSERT)) < 0 && !this.pressed)
            {
                if (this.show)
                {
                    base.Show();
                    this.show = false;
                }
                else
                {
                    base.Hide();
                    this.show = true;
                }
                this.pressed = true;
                return;
            }
            if (Form2.GetKeyState(Convert.ToInt32(VK.INSERT)) >= 0 && this.pressed)
            {
                this.pressed = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
