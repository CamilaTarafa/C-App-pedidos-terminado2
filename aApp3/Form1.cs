namespace aApp3
{
    using MySql.Data.MySqlClient;
    using System;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Random random = new Random();


            string[] pedidos = { "Pedido de pancho", "Pedido de sandwich", "Pedido de hamburguesa" };


            int indice = random.Next(pedidos.Length);


            MessageBox.Show($"Historial de pedidos del cliente: {pedidos[indice]}");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=clientespedidosya;User ID=root;Password=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO datos (dni, nombre, preferencia, direccion, correo, telefono) " +
                                  "VALUES (@dni, @nombre, @preferencia, @direccion, @correo, @telefono)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@dni", txtDNI.Text);
                    command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@preferencia", txtPreferencia.Text);
                    command.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    command.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    command.Parameters.AddWithValue("@telefono", txtTelefono.Text);

                    int result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error, no se pudo agregar el cliente: {ex.Message}");
                }

            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Random random = new Random();  
             
            string[] notis = {
            "Tu pedido está en camino.",
            "Tu pedido ha sido entregado.",
            "Tu pedido está en proceso."
    };
        
        string notificacion = notis[random.Next(notis.Length)];


        MessageBox.Show($"Notificación para el cliente: {notificacion}");
    }



}
    }
 
