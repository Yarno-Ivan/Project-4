
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
      <a class="p-2 lg:px-4 md:mx-2 text-white rounded bg-indigo-600" href="/gegevens">Menu</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-400 hover:text-gray-700 transition-colors duration-300" href="/overons">Over Ons</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-200 hover:text-gray-700 transition-colors duration-300" href="/Contact">Contact</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-transparent rounded hover:bg-indigo-100 hover:text-indigo-700 transition-colors duration-300" href="/login">Login</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-solid border-indigo-600 rounded hover:bg-indigo-600 hover:text-white transition-colors duration-300 mt-1 md:mt-0 md:ml-1" href="/register">Register</a>
    </div>
  </div>
</nav>
<body class="bg-gray-100">

<div class="font-bold text-3xl flex justify-center items-center ">Pas uw pizza {{ $pizzas->naam }} aan</div>
</br>
<div class="font-bold text-3xl flex justify-center items-center ">
    <form action="{{ route('guests.update', $pizzas->id) }}" method="POST">
        @csrf
        @method('PUT')
        <select name="grote van de pizza">
          <option value="klein">Klein</option>
          <option value="klein">Normaal</option>
          <option value="klein">Groot</option>
        </select>
        <button  type="submit">aanpassen</button>
    </form>
</div>
</body>
</html>

