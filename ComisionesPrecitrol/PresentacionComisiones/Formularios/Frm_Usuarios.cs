using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NegociosComisiones;
using System.Security.Cryptography;
using System.IO;
namespace PrecentacionComisiones.Formularios
{
    public partial class Frm_Usuarios : Form
    {
        Negocios_Usuarios Usuarios = new Negocios_Usuarios();
        public Frm_Usuarios()
        {
            InitializeComponent();
        }


        //public static string EncodePassword(string originalPassword)
        //{
        //    SHA1 sha1 = new SHA1CryptoServiceProvider();

        //    byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
        //    byte[] hash = sha1.ComputeHash(inputBytes);

        //    return Convert.ToBase64String(hash);
        //}

        public byte[] Clave = Encoding.ASCII.GetBytes("Tu Clave");
        public byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");
        public string Encripta(string Cadena)
        {

            byte[] inputBytes = Encoding.ASCII.GetBytes(Cadena);
            byte[] encripted;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes.Length))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateEncryptor(Clave, IV), CryptoStreamMode.Write))
                {
                    objCryptoStream.Write(inputBytes, 0, inputBytes.Length);
                    objCryptoStream.FlushFinalBlock();
                    objCryptoStream.Close();
                }
                encripted = ms.ToArray();
            }
            return Convert.ToBase64String(encripted);
        }
        public string Desencripta(string Cadena)
        {
            byte[] inputBytes = Convert.FromBase64String(Cadena);
            byte[] resultBytes = new byte[inputBytes.Length];
            string textoLimpio = String.Empty;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(Clave, IV), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(objCryptoStream, true))
                    {
                        textoLimpio = sr.ReadToEnd();
                    }
                }
            }
            return textoLimpio;
        }

        private void Cargar_Registros()
        {
            try
            {
                DataSet Cargar_Datos = new DataSet();
                Cargar_Datos = Usuarios.Usuarios_Registrados();
                // Gv_Datos.AutoGenerateColumns = false;
                //GV_Usuarios.DataSource = Cargar_Datos.Tables[0];
                foreach (DataRow myReader in Cargar_Datos.Tables[0].Rows)
                {
                    int renglon = GV_Usuarios.Rows.Add();

                    GV_Usuarios.Rows[renglon].Cells["Usu_Codigo"].Value = myReader[0].ToString();
                    GV_Usuarios.Rows[renglon].Cells["Usu_Usuario"].Value = myReader[1].ToString();
                    GV_Usuarios.Rows[renglon].Cells["Usu_Pasword"].Value = Encripta(myReader[2].ToString());
                    GV_Usuarios.Rows[renglon].Cells["Usu_Rol"].Value = myReader[3].ToString();
                    GV_Usuarios.Rows[renglon].Cells["Usu_Estado"].Value = myReader[4].ToString();
                }
                GV_Usuarios.Columns[0].Width = 30;
                GV_Usuarios.Columns[1].Width = 155;
                GV_Usuarios.Columns[2].Width = 100;
                GV_Usuarios.Columns[3].Width = 75;
                GV_Usuarios.Columns[4].Width = 75;
                // GV_Usuarios.Columns[2].UseSystemPasswordChar = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Transaccion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Txt_Codigo_Enter(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "CODIGO")
            {
                Txt_Codigo.Text = "";
                Txt_Codigo.ForeColor = Color.LightGray;
            }
        }

        private void Txt_Codigo_Leave(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                Txt_Codigo.Text = "CODIGO";
                Txt_Codigo.ForeColor = Color.DimGray;
            }
        }

        private void Txt_Usu_Enter(object sender, EventArgs e)
        {
            if (Txt_Usu.Text == "USUARIO")
            {
                Txt_Usu.Text = "";
                Txt_Usu.ForeColor = Color.LightGray;
            }
        }

        private void Txt_Usu_Leave(object sender, EventArgs e)
        {
            if (Txt_Usu.Text == "")
            {
                Txt_Usu.Text = "USUARIO";
                Txt_Usu.ForeColor = Color.DimGray;
                errorIcono.SetError(Txt_Usu, "SE DEBE INGRESAR UN USUARIO");
                //errorIcono.SetError(Txt_Usu, "");
            }
            else
            {
                errorIcono.SetError(Txt_Usu, "");
            }
        }

        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            if (Txt_Password.Text == "CONTRASEÑA")
            {
                Txt_Password.Text = "";
                Txt_Password.ForeColor = Color.LightGray;
                Txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void Txt_Password_Leave(object sender, EventArgs e)
        {
            if (Txt_Password.Text == "")
            {
                Txt_Password.Text = "CONTRASEÑA";
                Txt_Password.ForeColor = Color.DimGray;
                Txt_Password.UseSystemPasswordChar = false;
                errorIcono.SetError(Txt_Password, "SE DEBE INGRESAR UNA CONTRASEÑA");
            }
            else
            {
                errorIcono.SetError(Txt_Password, "");
            }
        }

        private void Txt_Password2_Enter(object sender, EventArgs e)
        {
            if (Txt_Password2.Text == "CONFIRMAR CONTRASEÑA")
            {
                Txt_Password2.Text = "";
                Txt_Password2.ForeColor = Color.LightGray;
                Txt_Password2.UseSystemPasswordChar = true;

            }
        }

        private void Txt_Password2_Leave(object sender, EventArgs e)
        {
            if (Txt_Password2.Text == "")
            {
                Txt_Password2.Text = "CONFIRMAR CONTRASEÑA";
                Txt_Password2.ForeColor = Color.DimGray;
                Txt_Password2.UseSystemPasswordChar = false;
                errorIcono.SetError(Txt_Password2, "SE DEBE CONFIRMAR LA CONTRASEÑA");
            }
            else
            {
                errorIcono.SetError(Txt_Password2, "");
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Btn_Guardar.Enabled = true;
            //Txt_Codigo.Text = "";
            //Txt_Usu.Text = "";
            //Txt_Password.Text = "";
            //Txt_Password2.Text = "";
            comboBox1.Text = "Seleccione";
            Txt_Usu.Enabled = true;
            Txt_Password.Enabled = true;
            Txt_Password2.Enabled = true;
            comboBox1.Enabled = true;
            Txt_Codigo.Text = Usuarios.Obtener_Codigo();
            Txt_Codigo.ForeColor = Color.LightGray;
            Txt_Usu.Focus();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Si la contraseña es igual
                if (Txt_Password.Text.Equals(Txt_Password2.Text))
                {

                    errorIcono.SetError(Txt_Password2, "");
                    errorIcono.SetError(Txt_Password, "");
                    if (Txt_Usu.Text.Equals("") | Txt_Password.Text.Equals("") | Txt_Password2.Text.Equals("") | comboBox1.Text.Equals("Seleccione"))
                    {
                        if (Txt_Password2.Text.Equals(""))
                        {
                            errorIcono.SetError(Txt_Password2, "LA CONTRASEÑA DEBE SER IGUAL");
                        }
                        else
                        {
                            errorIcono.SetError(Txt_Password2, "");

                        }
                        if (Txt_Password.Text.Equals(""))
                        {
                            errorIcono.SetError(Txt_Password, "SE DEBE INGRESAR UNA CONTRASEÑA");
                        }
                        else
                        {
                            errorIcono.SetError(Txt_Password, "");

                        }
                        if (comboBox1.Text.Equals("Seleccione"))
                        {
                            errorIcono.SetError(comboBox1, "SE DEBE SELECCIONAR UN ROL");
                        }
                        else
                        {
                            errorIcono.SetError(comboBox1, "");

                        }
                        if (Txt_Usu.Text.Equals(""))
                        {
                            errorIcono.SetError(Txt_Usu, "SE DEBE INGRESAR UN USUARIO");
                        }
                        else
                        {
                            errorIcono.SetError(Txt_Usu, "");

                        }
                    }
                    else
                    {
                        errorIcono.SetError(Txt_Password2, "");
                        errorIcono.SetError(Txt_Password, "");
                        errorIcono.SetError(comboBox1, "");
                        errorIcono.SetError(Txt_Usu, "");
                        string respuesta = Usuarios.Guardar_Usuario(Txt_Codigo.Text, comboBox1.Text, Txt_Usu.Text, Txt_Password.Text);
                        if (respuesta.Equals("Guardado"))
                        {
                            MessageBox.Show("Se creo el Usuario: " + Txt_Usu.Text + " Exitosamente", "Transaccion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Txt_Codigo.Text = "CODIGO";
                            Txt_Usu.Text = "USUARIO";
                            Txt_Password.Text = "CONTRASEÑA";
                            Txt_Password.UseSystemPasswordChar = false;

                            Txt_Password2.Text = "CONFIRMAR CONTRASEÑA";
                            Txt_Password2.UseSystemPasswordChar = false;

                            comboBox1.Text = "Seleccione";
                            Txt_Usu.Enabled = false;
                            Txt_Password.Enabled = false;
                            Txt_Password2.Enabled = false;
                            comboBox1.Enabled = false;
                        }
                        else if (respuesta.Equals("Usuario_Regitrado"))
                        {
                            MessageBox.Show("El Usuario: " + Txt_Usu.Text + " Ya se Encuentra Registrado", "Transaccion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (respuesta.Equals("Registro_Modificado"))
                        {
                            MessageBox.Show("Se Modifico el Usuario: " + Txt_Usu.Text + " Exitosamente", "Transaccion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Txt_Codigo.Text = "CODIGO";
                            Txt_Usu.Text = "USUARIO";
                            Txt_Password.Text = "CONTRASEÑA";
                            Txt_Password.UseSystemPasswordChar = false;
                            Txt_Password2.Text = "CONFIRMAR CONTRASEÑA";
                            Txt_Password2.UseSystemPasswordChar = false;
                            comboBox1.Text = "Seleccione";
                            Txt_Usu.Enabled = false;
                            Txt_Password.Enabled = false;
                            Txt_Password2.Enabled = false;
                            comboBox1.Enabled = false;
                        }

                    }



                }
                else
                {
                    errorIcono.SetError(Txt_Password2, "LA CONTRASEÑA DEBE SER IGUAL");
                    errorIcono.SetError(Txt_Password, "LA CONTRASEÑA DEBE SER IGUAL");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Transaccion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            Cargar_Registros();
        }
    }
}
