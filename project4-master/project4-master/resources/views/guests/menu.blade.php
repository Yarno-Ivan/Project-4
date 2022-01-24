
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
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-200 hover:text-gray-700 transition-colors duration-300" href="/">Home</a>
      <a class="p-2 lg:px-4 md:mx-2 text-white rounded bg-indigo-600" href="/menu">Menu</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-400 hover:text-gray-700 transition-colors duration-300" href="/overons">Over Ons</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-200 hover:text-gray-700 transition-colors duration-300" href="/Contact">Contact</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-transparent rounded hover:bg-indigo-100 hover:text-indigo-700 transition-colors duration-300" href="/login">Login</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-solid border-indigo-600 rounded hover:bg-indigo-600 hover:text-white transition-colors duration-300 mt-1 md:mt-0 md:ml-1" href="/register">Register</a>
    </div>
  </div>
</nav>
<body class="bg-gray-100">

<div class="font-bold text-3xl flex justify-center items-center ">Welkom op onze Pizza Menu pagina</div>
</br>
<div class="flex text-2xl font-bold py-2 px-4 flex-1 items-center flex justify-evenly">
  <a>Pizzas</a>
  <a>Info</a>
  <a>Prijs</a>
  <a>Pas uw Pizza aan</a>
  <div class="flex flex-row cursor-pointer truncate p-2 px-4  rounded">
  <div class="flex flex-row-reverse ml-2 w-full">
    <div slot="icon" class="relative">
        <svg onclick="window.location.href = '/betalen';" xmlns="http://www.w3.org/2000/svg" width="100%" height="100%" fill="none" viewBox="0 0 24 24" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-shopping-cart w-6 h-6 mt-2">
          <circle cx="9" cy="21" r="1"></circle>
          <circle cx="20" cy="21" r="1"></circle>
          <path d="M1 1h4l2.68 13.39a2 2 0 0 0 2 1.61h9.72a2 2 0 0 0 2-1.61L23 6H6"></path>
        </svg>
    </div>
  </div>
 </div>
</div>
</br>
@foreach ($pizzas as $pizza)
<div class="flex flex-wrap overflow-hidden xl:-mx-8">

  <form class="flex justify-evenly items-center flex-1" action="{{ route('guests.store', $pizza->id) }}" method="POST">
    @csrf
    <a>{{$pizza->naam}}</a>  
    <a>{{$pizza->info}}</a> 
    <a>{{$pizza->prijs}}</a>
    <a href="/menu/{{$pizza->id}}/edit">Aanpassen</a>
    <button type="submit">voeg toe</a>
  </form>
</div>
<br>

@endforeach
</body>
</html>

