# 📱 App Produção PET/Lata/Vidro

Aplicativo Android desenvolvido em **F# com Xamarin.Android** no **Visual Studio 2019**, com o objetivo de **calcular a produção de hora em hora** das linhas de produção **PET, Lata e Vidro**, e gerar relatórios detalhados para acompanhamento da eficiência.

---

## 🚀 Funcionalidades

- **[Cálculo de produção](ca://s?q=Calculo_de_producao_por_hora)**  
  Registra e calcula automaticamente a produção de cada linha (PET, Lata, Vidro) a cada hora.

- **[Relatórios](ca://s?q=Geracao_de_relatorios_de_producao)**  
  Geração de relatórios em formato visual e exportável (PDF/Excel) para análise.

- **[Monitoramento em tempo real](ca://s?q=Monitoramento_em_tempo_real)**  
  Dashboard com indicadores de desempenho por linha de produção.

- **[Histórico](ca://s?q=Historico_de_producao)**  
  Armazena dados para consultas posteriores e comparações de períodos.

---

## 🛠️ Tecnologias Utilizadas

- **[F#](ca://s?q=FSharp_para_Xamarin)** – linguagem funcional para lógica de cálculo.  
- **[Xamarin.Android](ca://s?q=Xamarin_Android)** – framework para desenvolvimento mobile nativo Android.  
- **[Visual Studio 2019](ca://s?q=Visual_Studio_2019)** – IDE principal para desenvolvimento.  
- **[SQLite](ca://s?q=SQLite_para_armazenamento_local)** – banco de dados local para persistência dos registros.  
- **[Material Design](ca://s?q=Material_Design_no_Xamarin)** – interface moderna e responsiva.  

---

## 📂 Estrutura do Projeto

/AppProducao
├── Activities/        # Telas principais (Dashboard, Relatórios, Configurações)
├── Models/            # Modelos de dados (Produção, Relatório)
├── Data/              # Persistência local (SQLite)
├── Resources/         # Layouts, imagens e estilos
├── bin/               # Saída de compilação (ignorada pelo Git)
├── obj/               # Arquivos temporários de build (ignorada pelo Git)
└── AppProducao.fsproj # Arquivo de projeto F#


---

## 📊 Exemplo de Relatório

- Produção PET: 1200 unidades/hora  
- Produção Lata: 950 unidades/hora  
- Produção Vidro: 800 unidades/hora  

Relatório consolidado mostra **eficiência por linha**, **média diária** e **alertas de baixa produção**.

---

## ▶️ Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/graaalberto/graaa-f-sharp-xamarim-android-refriango.git
2. Abra o projeto no Visual Studio 2019.
3. Compile e rode no emulador Android ou dispositivo físico.

📈 Futuras Melhorias
Integração com API REST para sincronização em nuvem.
Exportação automática de relatórios para Excel/PDF.
Notificações push em caso de baixa produção.

👨‍💻 Autor
Desenvolvido por Graaalberto  
Software Developer | Golang • React • C# • Xamarin.Android • F#   

