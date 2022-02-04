
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
<br>
<br>
<div class="font-bold text-3xl flex justify-center items-center ">Welkom voer uw gegevens in voordat u kan bestellen</div>
</br>
    <form  action="{{ route('guests.store') }}" class="w-1/3 m-auto" method="Post">
        @csrf
        <label class="font-semibold inline-block mb-3 text-sm ">Naam</label>
        <input name="naam"  type="text" placeholder="Vul uw naam in" class="p-2 text-sm w-full">
        <label class="font-semibold inline-block mb-3 text-sm ">Adress</label>
        <input name="adress" type="text" placeholder="Vul uw adress in" class="p-2 text-sm w-full">
        <label class="font-semibold inline-block mb-3 text-sm">Email</label>
        <input name="email" type="text" placeholder="Vul uw Email in" class="p-2 text-sm w-full">
        <br>
        <br>
        <br>
        <button type="submit" class="bg-indigo-600 font-semibold py-3 text-sm text-white uppercase w-full">stuur</button>
    </form>
</body>
</html>