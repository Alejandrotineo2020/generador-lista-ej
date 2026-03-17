namespace numero8
{
    public partial class MainPage : ContentPage
    {
       public List<int> MisNumeros { get; set; }

        public MainPage()
        {
            InitializeComponent();
         


        }

        private void OnGenerarClicked (object sender, EventArgs e)
        {
            if (int.TryParse(LimiteEntry.Text, out int numeroUsuario))
            {
                GenerarNumeros(numeroUsuario);
            }
        }



        private void GenerarNumeros (int limite)
        {
            List<int> listaNumeros = new List<int>();

            for (int i = 1; i <= limite; i++)
            {
                listaNumeros.Add(i);
            }


            NumerosListView.ItemsSource = listaNumeros;
        }



    }
}
