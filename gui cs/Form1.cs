using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gui_cs.Properties;

namespace gui_cs
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observers += new System.EventHandler(this.update_from_model);
        }

        private void nud_a_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(nud_a.Value);
            model.set(a, 1);
        }

        private void nud_b_ValueChanged(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(nud_b.Value);
            model.set(b, 2);

        }

        private void nud_c_ValueChanged(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(nud_c.Value);
            model.set(c, 3);
        }
        private void tb_a_TextChanged(object sender, EventArgs e)
        {
            int a;
            bool isNum = int.TryParse(tb_a.Text, out a);

            if (isNum)
            {
                a = Convert.ToInt32(tb_a.Text);
                model.set(a, 1);
            }

        }
        private void tb_b_TextChanged(object sender, EventArgs e)
        {
            int b;
            bool isNum = int.TryParse(tb_b.Text, out b);

            if (isNum)
            {
                b = Convert.ToInt32(tb_b.Text);
                model.set(b, 2);
            }

        }
        private void tb_c_TextChanged(object sender, EventArgs e)
        {
            int c;
            bool isNum = int.TryParse(tb_c.Text, out c);

            if (isNum)
            {
                c = Convert.ToInt32(tb_c.Text);
                model.set(c, 3);
            }

        }
        private void track_a_Scroll(object sender, EventArgs e)
        {
            model.set(track_a.Value, 1);
        }
        private void track_b_Scroll(object sender, EventArgs e)
        {
            model.set(track_b.Value, 2);
        }
        private void track_c_Scroll(object sender, EventArgs e)
        {
            model.set(track_c.Value, 3);
        }
        private void update_from_model(object sender, EventArgs e)
        {
            nud_a.Value = model.get(1);
            nud_b.Value = model.get(2);
            nud_c.Value = model.get(3);
            tb_a.Text = model.get(1).ToString();
            tb_b.Text = model.get(2).ToString();
            tb_c.Text = model.get(3).ToString();
            track_a.Value = model.get(1);
            track_b.Value = model.get(2);
            track_c.Value = model.get(3);

        }
        public class Model
        {
            private
                int a, b, c;
                void set()
            {
                if (c > 100) { c = 100; }
                if (b > c)
                {
                    b = c;
                }
                if (a > b)
                {
                    a = b;
                }
                Settings.Default["num_a"] = this.a;
                Settings.Default["num_b"] = this.b;
                Settings.Default["num_c"] = this.c;
                Settings.Default.Save();
            }
            public System.EventHandler observers;
            public void set(int el, int a)
            {
                if (el >= 0)
                {
                    switch (a)
                    {
                        case 1:
                            if (el > b)
                            {
                                this.a = b;
                            }
                            else
                            {
                                this.a = el;
                            }
                            set();
                            break;
                        case 2:
                            if (el > c)
                            {
                                b = c;
                            }
                            else
                            {
                                this.b = el;
                            }
                            set();
                            break;
                        case 3:
                            this.c = el;
                            set();
                            break;
                        default:
                            break;
                    }
                    observers.Invoke(this, null);
                }
            }
            public int get(int i)
            {
                switch (i)
                {
                    case 1:
                        return this.a;
                        break;
                    case 2:
                        return this.b;
                        break;
                    case 3:
                        return this.c;
                        break;
                    default:
                        return 0;
                        break;
                }
            }
            public void check_update()
            {
                observers.Invoke(this, null);
            }
            public Model()
            {
                int num_a = Convert.ToInt32(Settings.Default["num_a"]);
                int num_b = Convert.ToInt32(Settings.Default["num_b"]);
                int num_c = Convert.ToInt32(Settings.Default["num_c"]);
                this.a = num_a;
                this.b = num_b;
                this.c = num_c;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model.check_update();
        }
    }
}
