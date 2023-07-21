namespace AtividadeEstacionamento
{
	public partial class Form1 : Form
	{
		public List<string> Veiculos = new List<string>();
		public Form1()
		{
			InitializeComponent();
		}

		void limpaCampos()
		{
			
			txtPlaca.Clear();
			txtPlaca.Focus();
		}

		bool listaEstaVazia()
		{
			if (Veiculos.Count() > 0)
			{
				return false;
			}
			else
			{

				return true;

			}
		}
			bool Verificar()
			{
				string nome = txtPlaca.Text;
				if (Veiculos.Contains(nome) )
				{

				return true;
				}
				else
				{
				return false;
				}

			}
			void adicionaVeiculo()
			{
			string nome;
				
				nome = txtPlaca.Text;
				Veiculos.Add(nome);
			listVeiculos.Items.Clear();
				
				for (int i = 0; i < Veiculos.Count; i++)
				{
				listVeiculos.Items.Add($"[VAGA {i}] - {Veiculos[i]}");
				}
			}

			void removerVeiculo()
			{
			for (int i = 0; i < Veiculos.Count; i++)
			{
				string nome = txtPlaca.Text;
				if (Veiculos[i] == nome)
				{
					Veiculos.RemoveAt(i);
					listVeiculos.Items.RemoveAt(i);
				}
			}
			
				if (listaEstaVazia() == true)
				{
				MessageBox.Show("Não há Veículos na Lista");
				}else{
				string nome;
				nome = txtPlaca.Text;
				Veiculos.Remove(nome);

				}
				

			}

			void atualizaInterface()
			{
				int quantidade = Veiculos.Count();
				lblVeiculos.Text = quantidade.ToString();


			}
		

			private void label3_Click(object sender, EventArgs e)
			{

			}

			private void btnEstacionar_Click(object sender, EventArgs e)
			{
			string nome = txtPlaca.Text;
			if (Veiculos.Count >= 5)
			{
				MessageBox.Show("O estacionamento está lotado");
			}
			if (Verificar() == true)
			{
				MessageBox.Show("Esse Veículos já está estacionado");
				return;
			}
		
				adicionaVeiculo();
				atualizaInterface();
				
			
				limpaCampos();
				MessageBox.Show($"Veículo {nome} adicionado com sucesso");
			
			}

		private void btnRetirar_Click(object sender, EventArgs e)
		{
			string nome = txtPlaca.Text;
			if (nome == "")
			{
				MessageBox.Show("Por favor, Digite a placa");
			}
			
			removerVeiculo();
			atualizaInterface();
			MessageBox.Show($"Veículo {nome} removdo com sucesso");
		}

		private void listVeiculos_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
