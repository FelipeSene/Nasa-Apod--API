# Nasa-Apod-API

![Badge em Confi](http://img.shields.io/static/v1?label=FUNCIONALIDADE&message=%20Receber%20fotos%20diárias%20e%20consultar%20imagens%20antecessoras%20ao%20dia%20atual%20&color=blueviolet&style=for-the-badge)


<div>

  <h1 align="center"><img src="https://github.com/Mazzuc/Nasa-Apod--API/assets/101806906/29402ae8-0d29-41ca-9c51-1bc870d5b2e5" height="200px" width="200px"/> </h1>

  <h1 align="center"> Picture of the Day  </h1>
</div><bR>

 <h3> <b> :movie_camera: Vídeo do aplicativo em funcionamento - Planetas:</b></h3>
<br>

<details close="Mapa"> 

  
<summary><b>Url do vídeo:</summary></b>
     <p <i class="devicon-firebase-plain"></i> Link do vídeo: https://youtu.be/cixLhDKy1f8 </p><BR>
       </details>
       

 <details close="api"> 

<summary><b>Nova API:</summary></b>
     <p <i class="devicon-firebase-plain"></i>Devido à nossa antiga API (APOD - Nasa) ficar fora de ar, tivemos que escolher
  outra API para substituí-la rapidamente e, como tal, escolhemos a: Planets Api.</p><BR><BR>
      <p <i class="devicon-firebase-plain"></i>Link da documentação da API: https://github.com/k99sharma/planets-api</p><BR>
 </details>





  # :chart_with_downwards_trend: Funcionalidades do projeto
 Aplicativo em desenvolvimento para pessoas amantes de fotografias, podendo publicar lindas imagens diariamente e consulta-las quando quiser!
 Tradução: Uma biblioteca Java para acessar a API Picture of the Day (APOD) baseada em HTTP. Esta aplicação está disponivel para celulares antigos e modernos.
  <br><br>
 *Dupla:* Eduardo Andreolli e Felipe Sene | 3° DS | Programação Mobile (*Prof°:* Aline Firmino Brito)<br>

<bR>
  

  <details open="sumarioo"><br>
 <summary><b>Sumário:</summary></b>
  
- [URL da Documentação](#1)
- [URL de Acesso](#2)
- [Métodos Disponíveis (endpoints) e indicação de qual/quais serão implementados na aplicação](#3)
- [Atributos/Parâmetros solicitados por cada método](#4)
- [Dados retornados para cada método (Dicionário de dados](#5)
- [Diagrama de Classes e Diagrama de Banco de Dado](#6)
- [Mapa de Navegação da Aplicação](#7)
- [URL/Fotos - Protótipo](#7)


</details>
  
  <br>
  
 <h3> <b>🖇️ URL da Documentação:</b></h3>
 https://github.com/nasa/apod-api<br>
 
 <bR>
 
   <h3>  📎<b> URL de Acesso:</b></h3>
 https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY<br>


 <h3> <b> 📔	 Métodos disponíveis</b></h3>

- `apod_object_parser.get_dat 1`: a get_date função pega o dicionário que obtivemos acima e retorna a data.
- `apod_object_parser.get_explaination`: a get_explaination função pega o dicionário que obtivemos acima e retorna a explicação.
- `apod_object_parser.get_hdurl`: a get_hdurl função pega o dicionário que obtivemos acima e retorna a url de alta definição da imagem.
- `apod_object_parser.get_media_type`: a get_media_type função pega o dicionário que obtivemos acima e retorna o tipo de mídia do arquivo (pode ser um vídeo de uma imagem).
- `apod_object_parser.get_title`: a get_title função pega o dicionário que pegamos acima e retorna o título da imagem.
- `apod_object_parser.get_url`: a get_url função pega o dicionário que obtivemos acima e retorna a url de definição padrão da imagem.


<br>
 <h3> <b>💾 Pâramentros soliciatos por cada método </b></h3>


- `api_key`: Demonstração: DEMO_KEY | https://api.nasa.gov/#signUp
- `date`: É uma STRING no formado AAAA-MM-DD - exemplo: 2023-14-01. 
- `concept_tags`: É um BOOLEANO True | False a qual indica se as tags devem ser retornadas com o restante da resposta. Seu padrão é Falso.
- `hd`: É um parâmetro BOOLEANO True | Falso a qual indica se as imagens de alta resolução podem ou não serem retornadas, são retornados independemente. 
- `count`: Número INTEIRO positivo > 100, não pode ser utilizado com date e nem variantes. 
- `thumbs`: É um parâmetro BOOLEANO True | False o qual indica se a API deve retornar um URL da imagem.

<br>
    <h3> <b>📼 Dados retornados para cada atributo. </b></h3>
  
- `resource `: Um dicionáriaa que descreve o image.
- `title `:O título da image.
- `date`: Data da imagem e a resposta dos valores.
- `URL`: A URL da imagem APOD do dia.
- `hdurl`: A URL de qualquer imagem com alta resolução, caso tenha.
- `media_type `: O tipo de mídia (dados) refornado.
- `explanation `: Conceito do texto fornecido pela imagem; 
- `copyright `: O nome do detentor dos direitos autorais.
   
   <br>
   
  <br>
  
 <h3>  📂  Diagrama de Classes e Banco de Dados</h3>
    

<details close="classe">
<summary><b>Diagrama de Classes</summary></b>
<h1 align="center"><img src= "https://user-images.githubusercontent.com/101806906/236333540-a177615d-d392-4181-8856-78278e4c858d.png" heigth="800px" width="1000px"/></h1>
  </details>
  
<details close="classe">
  <summary><b>Diagrama de Banco de Dados</summary></b>
<h1 align="center"><img src= "https://user-images.githubusercontent.com/101806906/236333781-351b50b2-5cfb-44c1-82ca-3d90379c73d6.png" heigth="800px" width="1000px"/></h1>
</details>

<details close="classe">
  <summary><b>Diagrama MER</summary></b>
<h1 align="center"><img src= "https://github.com/FelipeSene/Nasa-Apod--API/assets/91497871/498ab871-1e08-42a9-870a-04fbaa70bc02" heigth="800px" width="1000px"/></h1>
</details>
   
   <br>
   
   
  ## :chart_with_downwards_trend:   Protótipo - Mapa de Navegação e suas respectivas funcionalidades:
<br>
<details close="Mapa"> 
  
<summary><b>Protótipo:</summary></b>
  
  <h3> Visualização do Protótipo: https://www.figma.com/file/BollsJOdyP4N2FE1RkYp7M/Untitled?node-id=0-1&t=yyswIDWRms1SFtfF-0
    
  </h3> <BR>
<h1 align="center"><img src= "https://user-images.githubusercontent.com/101806906/236352136-98c04b94-4f28-4523-b87c-7e5cbfb97c6b.png" heigth="800px" width="1000px"/></h1>
  <br>
  
  </details>
   

 <details close="Mapa"> 
  
<summary><b>Mapa de Navegação:</summary></b>
   
 
  
<h1 align="center"><img src= "https://user-images.githubusercontent.com/101806906/236353038-ebd8abbf-4a9c-4c59-a820-be16ef267df7.png" heigth="800px" width="1000px"/></h1>
  </details>
  

   <details close="Mapa"> 
  
<summary><b>Descrição e funcionalidades da aplicação:</summary></b>
     <h3 <i class="devicon-firebase-plain"></i>     A aplicação de baseia em um amplo conjunto de dados referentes as belezas da astronomia. Baseando-se no conceito proposto, foi escolhido uma API (POD - NASA) que se encaixe perfeitamente, a qual tem o objetivo de fornecer imagens sobre distintas paisagens do céu. Com o login feito, o usuário terá acesso a grade de imagens que a API proporciona, podendo consulta-las aleatoriamente ou por datas, recebendo um URL como resultado para poder visualiza-las e favorita-las quando quiser. Ademais, a aplicação possui telas informativas referentes aos sistemas galácticos, com o intuito de agregar informações mais relevantes e precisas.</h3><BR><BR>
  </details>
