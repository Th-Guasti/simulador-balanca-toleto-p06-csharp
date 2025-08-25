using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Globalization;
using System.ComponentModel;

/*
 * Simulador de Balança Toledo - Protocolo P06
 * Autor: Thales de Souza Guasti
 * Data de criação: 25/08/2025
 * Email: thaslesouza@gmail.com
 * 
 * Descrição:
 * Este programa simula uma balança compatível com o protocolo P06 da Toledo.
 * Comunica via porta serial e responde ao comando STX (0x02) enviando o peso simulado no formato ASCII, entre STX e ETX.
 * 
 * Mudando para o protocolo P05:
 * - O protocolo P05 normalmente utiliza o byte ENQ (0x05) para solicitar peso.
 * - Para adaptar, altere a identificação de comando na função PortaSerial_DataReceived para:
 *   if (buffer.Length > 0 && buffer[0] == 0x05)
 *   {
 *       EnviarPesoSimulado();
 *   }
 */

namespace Simulador_da_balança
{
    public partial class simulador_balanca : Form
    {
        public simulador_balanca()
        {
            InitializeComponent(); //carrega a interface visual
            AbrirPortaSerial("COM4"); //abre a porta serial
            txtSimulacaoPeso.Text = "0.000";

            //evento de mudança de texto do campo de peso
            txtSimulacaoPeso.TextChanged += TxtSimulacaoPeso_TextChanged;

            //inicia com a etiqueta de peça invisível
            lblPeca.Visible = false;

            //eventos dos botões
            btnPeca.Click += BtnPeca_Click;
            btnPesoMais.Click += BtnPesoMais_Click;
            btnPesoMenos.Click += BtnPesoMenos_Click;

            //eventos do campo de peso
            txtSimulacaoPeso.KeyPress += txtSimulacaoPeso_KeyPress; //permite apenas números e vírgula/ponto
            txtSimulacaoPeso.Validating += txtSimulacaoPeso_Validating; //validação do campo de peso
                                                                       
            this.Shown += simulador_balanca_Shown;
        }

        private void simulador_balanca_Shown(object sender, EventArgs e)
        {
            txtSimulacaoPeso.Focus();
        }

        private void AbrirPortaSerial(string porta)
        {
            //configura e abre a porta serial
            try
            {
                serialPort = new SerialPort(porta, 9600, Parity.None, 8, StopBits.One); //configurações da porta serial
                serialPort.DataReceived += PortaSerial_DataReceived; //evento que será chamado ao receber dados pela portarecebidos
                serialPort.Open(); //abre a porta serial
                lblCom.Text = "Porta serial " + porta + " aberta com sucesso!";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir a porta serial: {porta} : {ex.Message}");
            }
        }

        private void PortaSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //lê os dados recebidos da porta serial
            try
            {
                int bytesToRead = serialPort.BytesToRead; //número de bytes disponíveis para leitura
                byte[] buffer = new byte[bytesToRead]; //buffer para armazenar os dados recebidos
                serialPort.Read(buffer, 0, bytesToRead); //lê os dados da porta serial

                string hexReceived = BitConverter.ToString(buffer).Replace("-", " ");  //converte os dados recebidos para formato HEX

                Invoke(new Action(() => //atualiza a interface gráfica
                {
                    txtRecepcaoDados.Text = hexReceived; //exibe os dados recebidos em HEX
                }));

                //verifica se o comando é STX (0x02), no protocolo P06
                if (buffer.Length > 0 && buffer[0] == 0x02)
                {
                    EnviarPesoSimulado();
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    txtRecepcaoDados.AppendText($"Erro ao receber dados: {ex.Message}\r\n");
                }));
            }
        }

        private void EnviarPesoSimulado() 
        {
            //envia o peso simulado formatado pela porta serial
            if (serialPort != null && serialPort.IsOpen)
            {
                decimal peso;

                //tenta converter o texto do peso para decimal, substituindo vírgula por ponto
                if (!decimal.TryParse(txtSimulacaoPeso.Text.Replace(',', '.'), out peso))
                {
                    peso = 0; //se falhar, define o peso como 0
                }

                string pesoFormatado = peso.ToString("00.000").Replace(',', '.'); //formata o peso com 2 dígitos antes e 3 depois da vírgula

                byte[] resposta = new byte[1 + pesoFormatado.Length + 1]; //cria um array de bytes para a resposta (STX + peso + ETX)

                //adiciona o caractere STX (0x02) no início da resposta
                resposta[0] = 0x02; 

                //adiciona o peso formatado ao array de resposta
                for (int i = 0; i < pesoFormatado.Length; i++) //converte cada caractere do peso formatado para byte
                {
                    resposta[i + 1] = (byte)pesoFormatado[i]; //adiciona o byte ao array de resposta
                }
                //adiciona o caractere ETX (0x03) ao final da resposta
                resposta[resposta.Length - 1] = 0x03;

                serialPort.Write(resposta, 0, resposta.Length); //envia a resposta pela porta serial

                
                string hexResposta = BitConverter.ToString(resposta).Replace("-", " "); //converte a resposta para formato HEX
                txtEnvioDados.Invoke(new Action(() =>
                {
                    txtEnvioDados.Text = $"Enviado: {pesoFormatado}\r\nHEX: {hexResposta}";
                }));
            }
        }


        private void TxtSimulacaoPeso_TextChanged(object sender, EventArgs e)
        {
            decimal peso;

            //atualiza o label dinâmico com o peso formatado
            if (decimal.TryParse(txtSimulacaoPeso.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out peso))
            {
                lblDinamico.Text = peso.ToString("00.000", CultureInfo.InvariantCulture); //formata o peso com 2 dígitos antes e 3 depois da vírgula
            }
            else //se a conversão falhar, exibe 00.000
            {
                lblDinamico.Text = "00.000";
            }
        }

        private void BtnPesoMais_Click(object sender, EventArgs e)
        {
            decimal peso;
            //incrementa o peso em 0.100
            if (decimal.TryParse(txtSimulacaoPeso.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out peso))
            {
                peso += 0.100m;
                txtSimulacaoPeso.Text = peso.ToString("0.000", CultureInfo.InvariantCulture);
            }
            else
            {
                txtSimulacaoPeso.Text = "0.000";
            }
        }

        private void BtnPesoMenos_Click(object sender, EventArgs e)
        {
            decimal peso;
            if (decimal.TryParse(txtSimulacaoPeso.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out peso))
            {
                peso -= 0.100m;
                if (peso < 0) peso = 0;
                txtSimulacaoPeso.Text = peso.ToString("0.000", CultureInfo.InvariantCulture);
            }
            else
            {
                txtSimulacaoPeso.Text = "0.000";
            }
        }

        private decimal pesoAnterior = 0;

        private void BtnPeca_Click(object sender, EventArgs e)
        {
            //simula a colocação ou remoção de uma peça na balança
            if (lblPeca.Visible)
            {
                pesoAnterior = decimal.TryParse(txtSimulacaoPeso.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out pesoAnterior) ? pesoAnterior : 0; //armazena o peso atual antes de remover a peça
                btnPeca.Text = "Colocar peça na Balança";
                txtSimulacaoPeso.Text = "0.000";
                lblPeca.Visible = false;
            }
            else
            {
                lblPeca.Visible = true;
                btnPeca.Text = "Remover peça da Balança";
                txtSimulacaoPeso.Text = pesoAnterior.ToString("0.000", CultureInfo.InvariantCulture);
            }
        }

        //validação do campo de peso para aceitar apenas números, vírgula e ponto
        private void txtSimulacaoPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',') //permite apenas números, vírgula, ponto e teclas de controle
            {
                e.Handled = true; //ignora o caractere se não for número, vírgula, ponto ou tecla de controle
            }
        }

        //validação do campo de peso para garantir que o valor esteja entre 0.000 e 150.000
        private void txtSimulacaoPeso_Validating(object sender, CancelEventArgs e)
        {
            decimal peso;
            if (!decimal.TryParse(txtSimulacaoPeso.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out peso))
            {
                MessageBox.Show("Digite um valor numérico válido para o peso.");
                e.Cancel = true; //cancela a validação
                return;
            }

            if (peso < 0m) peso = 0m; 
            if (peso > 150m) peso = 150m;

            txtSimulacaoPeso.Text = peso.ToString("0.000", CultureInfo.InvariantCulture);
        }
    }
}
