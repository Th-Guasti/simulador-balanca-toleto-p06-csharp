# Simulador de Balança Toledo (Protocolo P06)

## Descrição

Este projeto é um simulador de balança eletrônica Toledo compatível com o protocolo P06, utilizado para desenvolvimento e testes de integração com softwares que se comunicam via porta serial com balanças físicas.

O simulador recebe comandos via porta serial (STX `0x02`) e responde com o peso simulado no formato ASCII, encapsulado entre os caracteres-STX e ETX. Assim, o simulador imita o comportamento real de dispositivos de pesagem Toledo para facilitar testes sem necessidade de hardware físico.

---

## Funcionalidades

- Simulação de peso configurável via interface gráfica.
- Comunicação via porta serial configurada (default COM4, 9600bps, 8N1).
- Resposta ao protocolo P06, reconhecendo comando STX (0x02).
- Envio do peso formatado como texto ASCII entre caracteres STX e ETX.
- Controle de peso por incrementos e decrementos.
- Simulação de colocação e remoção de peça na balança, com peso armazenado.
- Visualização do comando recebido e da resposta enviada no formato hexadecimal.
- Validação de valores de peso aceitando apenas números, pontos e vírgulas.

---

## Requisitos

- Windows com .NET Framework compatível para rodar o aplicativo Windows Forms.
- Porta serial física ou virtual configurada para comunicação (exemplo para testes: uso de portas COM virtuais com software como com0com, com2com, etc).
- Software terminal serial para enviar comandos (exemplo: Termite, RealTerm) ou software cliente customizado.

---

## Como usar

1. Clone ou baixe este repositório.
2. Abra o projeto no Visual Studio.
3. Configure a porta serial correta no código-fonte (padrão é COM4).
4. Compile e execute o simulador.
5. Utilize um software cliente ou terminal serial para enviar o comando `0x02` (STX) via porta serial configurada para o simulador.
6. Visualize a resposta com o peso simulado na interface do cliente.
7. Altere e configure o peso pela interface do simulador para testar diferentes situações.
8. Utilize os botões para adicionar/remover peça e ajustar o peso.

---

## Configuração do protocolo

Por padrão, o simulador usa o protocolo P06 e responde ao comando `STX (0x02)`.

Para mudar para o protocolo P05:

- Na função `PortaSerial_DataReceived`, altere o teste para responder ao comando `ENQ (0x05)`:
  if (buffer.Length > 0 && buffer == 0x05)
  {
    EnviarPesoSimulado();
  }
  
- Ou para suportar ambos:
  if (buffer.Length > 0 && (buffer == 0x02 || buffer == 0x05))
  {
    EnviarPesoSimulado();
  }

---

## Estrutura do código

- `simulador_balanca`: classe principal do Windows Form, gerencia a interface e lógica.
- `AbrirPortaSerial`: abre e configura a comunicação serial.
- `PortaSerial_DataReceived`: recebe os comandos e determina se deve responder.
- `EnviarPesoSimulado`: monta e envia o pacote com o peso simulado.
- Eventos de interface gerenciam a simulação do peso, incrementos, validação e simulação da peça.

---

## Contato

Thales de Souza Guasti  
Email: thaslesouza@gmail.com  
Linkedin: www.linkedin.com/in/thales-de-souza-guasti-272722290
