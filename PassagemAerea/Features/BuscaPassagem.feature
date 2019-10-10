#language: pt

Funcionalidade: Pesquisa de compra de passagem
	Como um usuário
	Quero realizar uma pesquisa de passagem aérea
	Para visualizar os preços

@mytag
	Cenário:  Pesquisar passagem aérea 
	Dado que acessei a aplicação
	Quando faço uma pesquisa de compra de passagem
	E seleciono a opção compre aqui	
	Então devo visualizar a tela Escolha seu Voo
	E seleciono a menor tarifa do dia 