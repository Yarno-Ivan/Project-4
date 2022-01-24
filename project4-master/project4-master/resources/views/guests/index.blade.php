
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Stonks pizza</title>
    <link href="{{ asset('css/app.css') }}" rel="stylesheet">
</head>
<body>
<nav class="bg-white py-2 md:py-4">
  <div class="container px-4 mx-auto md:flex md:items-center">

    <div class="flex justify-between items-center">
    <img class="h-20 w-50" src="{{ URL::to('/assets/img/stonkspizza.jpg') }}">
    </div>
    <div class="hidden md:flex flex-col md:flex-row md:ml-auto mt-3 md:mt-0" id="navbar-collapse">
      <a class="p-2 lg:px-4 md:mx-2 text-white rounded bg-indigo-600" href="/">Home</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-200 hover:text-gray-700 transition-colors duration-300" href="/menu">Menu</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-400 hover:text-gray-700 transition-colors duration-300" href="/overons" >Over Ons</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-200 hover:text-gray-700 transition-colors duration-300" href="/Contact">Contact</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-transparent rounded hover:bg-indigo-100 hover:text-indigo-700 transition-colors duration-300" href="/login">Login</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-solid border-indigo-600 rounded hover:bg-indigo-600 hover:text-white transition-colors duration-300 mt-1 md:mt-0 md:ml-1" href="/register">Register</a>
    </div>
  </div>
</nav>

<div class="flex flex-wrap -mx-px overflow-hidden sm:-mx-6 mt-20 ml-10 ">

  <div class="my-px px-px w-1/2 overflow-hidden sm:my-6 sm:px-6 text-center">
    <h1 class="text-5xl">Welkom bij Stonks Pizza</h1>
    <br>
    <br>
    <br>
    <br>
    <br>
    <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.</br>
 Lorem Ipsum has been the industry's standard dummy text ever since the </br>
 Lorem Ipsum is simply dummy text of the printing and typesetting industry.
</p>
<br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <a class="text-sm font-bold tracking-wide bg-indigo-600 text-gray-100 p-3 rounded-lg focus:outline-none focus:shadow-outline  " href="/menu" >Bekijk ons menu</a> 
  </div>

  <div class="my-px px-px w-1/2 overflow-hidden sm:my-6 sm:px-6">
  <img  src="{{ URL::to('/assets/img/pizza.jpg') }}">
  </div>

</div>

</body>
</html>
<div class="header-2">


