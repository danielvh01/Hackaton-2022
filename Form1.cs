namespace Hackaton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            string text1 = "", text2 = "";
            text1 = txtScr1.Text.ToUpper();
            text2 = txtScr2.Text.ToUpper();
            if (text1 != "" && text2 != "")
            {
                if (text1.Length == text2.Length)
                {
                    List<string> list = new List<string>();
                    List<string> list2 = new List<string>();

                    for (int i = 0; i < text1.Length; i++)
                    {
                        list.Add(text1[i].ToString());
                        list2.Add(text2[i].ToString());
                    }

                    list.Sort();
                    list2.Sort();

                    bool verif = true;

                    for (int i = 0; i < text1.Length; i++)
                    {
                        if (list[i] != list2[i]) {
                            verif = false; break;
                        }
                    }

                    if (verif)
                    {
                        lblResult1.Text = "TRUE: La segunda cadena es una cadena \n desordenada de la primera cadena.";
                    }
                    else
                    {
                        lblResult1.Text = "FALSE: La segunda cadena NO es una cadena \n desordenada de la primera cadena.";
                    }

                }
                else
                {
                    lblResult1.Text = "FALSE: Las cadenas deben ser de la misma longitud.";
                }
            }
            else
            {
                lblResult1.Text = "Debe de ingresar las cadenas";
            }
        }

        private void btnJustificar_Click(object sender, EventArgs e)
        {
            string text1 = rich1.Text;  

            if(text1 != "")
            {
                string[] lines = text1.Split("\n");
                for(int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Length < 30)
                    {
                        int n = 30 - lines[i].Length;   
                        int n2 = lines[i].Split(" ").Length;
                        for()
                    }
                }

            }
            else
            {
                rich2.Text = "Debe ingresar texto en la entrada.";
            }
        }
    }
}