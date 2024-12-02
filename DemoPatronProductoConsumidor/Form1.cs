using System.Drawing.Text;

namespace DemoPatronProductoConsumidor
{
    public partial class Form1 : Form
    {
        private int contadorId = 1;
        private Cola<Usuario> colaUsuario;
        private Productor productor;
        private Consumidor consumidor;
        public Form1()
        {
            InitializeComponent();
            colaUsuario = new Cola<Usuario>(10);
            productor = new Productor(colaUsuario);
            consumidor = new Consumidor(colaUsuario);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario(
                contadorId++,
                txtNombre.Text,
                txtTipoCosina.Text
                );

            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaUsuario.Agregaar(nuevoUsuario);
                }
                );


            txtNombre.Clear();
            txtTipoCosina.Clear();

        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarUsuario);
            hiloConsumidor.Start();
        }
       private void ProcesarUsuario()
        {
            Usuario usuario = colaUsuario.Extraer();
            AgregarUsuarioADataGrib(usuario);
                
         }
        private void AgregarUsuarioADataGrib(Usuario usuario)
        {
            if (dgvUsuarios.InvokeRequired)
            {
                dgvUsuarios.Invoke(new Action(() =>
                {
                    dgvUsuarios.Rows.Add(
                        usuario.Id, usuario.Nombre,
                        usuario.TipoCosina,
                        usuario.FechaCreacion
                        );
                })
                    );
            }
            else 
            {
                dgvUsuarios.Rows.Add(
                           usuario.Id, usuario.Nombre,
                           usuario.TipoCosina,
                           usuario.FechaCreacion
                           );
            }
        }
    }
}
