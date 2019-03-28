# REDIRECIONAMENTO
Aula de Desenvolvimento web com o professor Rodrigo

Entregar até 15hrs do dia 28/03/2019 (quinta-feira)
Atividade
Montar um projeto Web no Visual Studio que contenha uma página que faça a chamada de outra página,
porém com passagem de parâmetro. Qualquer valor e tipo de parâmetro é válido, desde que chegue ai destino.

# Intrucoes
Fazer download do .ZIP(não clonar o projeto), descompacte no seu diretorio de preferencia, já no visual studio, use o atalho (Ctrl+Shift+O), ou clique na aba "Arquivo"->"abrir"->"projeto/Solucao" busque e abra a pasta descompactada "Redirecionamento", e em seguida abra o arquivo Redirecionamento.sln,  Favor limpar e recompilar projeto antes de executar, "aqui deu erro sem fazer isso", e sempre executar projeto quando com atalho "ctrl+F5" a partir de uma controller, e nunca de uma view ou outro arquivo "se nao vai acontecer varios bugs", ou simplesmente execute o projeto inteiro com o atalho "F5" ou clique no play(navegador de preferencia), ou ainda na aba "depurar"->"Iniciar depuracao".

# Execucao
Quando o projeto for executado sera aberto e exibido no navegador a pagina inicial denominada Index que fica no caminho(SeuDiretorioDePreferencia\REDIRECIONAMENTO-master\REDIRECIONAMENTO\Views\Main\Index.cshtml), nela tera a descricao da pagina, e a explicacao de como as chamadas funcionam, e será listado 3 links de redirecionamento nesta ordem (Fale conosco, Quem somos, Trabalhe conosco).
-se clicar no link (Fale conosco) sera direcionado para a view Falando, que fica no caminho(SeuDiretorioDePreferencia\REDIRECIONAMENTO-master\REDIRECIONAMENTO-master\REDIRECIONAMENTO\Views\Coisas\Falando.cshtml), nesta view tera mais 3 links nesta ordem (Inicio "Minha view index", Quem somos, Trabalhe conosco), no qual o link (Inicio "Minha view index") te retornara para a pagina inicial.
-
