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
            lblResult1.Visible = true;
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
                        string [] n2 = lines[i].Split(" ");
                        int n3 = (int) Math.Round((double) n /( n2.Length -1),MidpointRounding.ToPositiveInfinity);
                        lines[i] = "";

                        for(int j = 0; j < n2.Length -1; j++)
                        {
                            n2[j] = n2[j].PadRight(n3 + n2[j].Length +1,' ');
                            lines[i] += n2[j];
                        }
                        lines[i] += n2[n2.Length - 1];
                    }
                    rich2.Text += lines[i] + "\n";     
                }
                
            }
            else
            {
                rich2.Text = "Debe ingresar texto en la entrada.";
            }
        }

        private void btnVerif1_Click(object sender, EventArgs e)
        {
            lblResC.Visible = true;
            string text1 = "", text2 = "",result = "";
            text1 = txtCS1.Text.ToUpper();
            text2 = txtCS2.Text.ToUpper();
            if (text1 != "" && text2 != "")
            {
                int min = 0;
                if(text1.Length < text2.Length)
                {
                    min = text1.Length; 
                }
                else
                {
                    min = text2.Length; 
                }

                for(int i = 0; i < min; i++)
                {
                    if (text1[i] == text2[i])
                    {
                        result += text1[i];
                    }
                }
                if (result == "")
                {
                    lblResC.Text = "No hay cadenas subsecuentes";
                }
                else
                {
                    lblResC.Text = "La cadena subsecuente encontrada es: " + result;
                }
                               
            }
            else
            {
                lblResC.Text = "Debe de ingresar las cadenas";
            }
        }

        private void btnAbuela_Click(object sender, EventArgs e)
        {
            lblAbuela.Visible = true;
            int N = 0, n1 = 0, n2 = 0;

            

            if (txtTotal.Text != "" && txtSumando1.Text != "" && txtSumando2.Text != "" )
            {
                if(int.TryParse(txtTotal.Text,out N) && int.TryParse(txtSumando1.Text, out n1) && int.TryParse(txtSumando2.Text, out n2))
                {
                    try
                    {
                        n1 = Convert.ToInt32(txtSumando1.Text, 2);
                        n2 = Convert.ToInt32(txtSumando2.Text, 2);
                        if(N == n1 + n2)
                        {
                            lblAbuela.Text = "La abuela le regalará a su nieta " + n1.ToString() + " avellanas.";
                        }
                        else
                        {

                            lblAbuela.Text = "Los sumandos no cuadran con el total ingresado.";
                        }
                    }
                    catch (Exception )
                    {
                        lblAbuela.Text = "Las entradas de lo sumandos deben estar en base 2 (binario).";
                    }

                }
                else
                {
                    lblAbuela.Text = "Todos los valores ingresados en los campos deben ser NUMEROS.";
                }
            }
            else
            {
                lblAbuela.Text = "Debe llenar todos los campos";
            }
        }
    }
}