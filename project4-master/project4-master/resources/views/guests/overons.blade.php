
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
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-200 hover:text-gray-700 transition-colors duration-300" href="/gegevens">Menu</a>
      <a class="p-2 lg:px-4 md:mx-2 text-white rounded bg-indigo-600" href="/overons">Over Ons</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-200 hover:text-gray-700 transition-colors duration-300" href="/Contact">Contact</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-transparent rounded hover:bg-indigo-100 hover:text-indigo-700 transition-colors duration-300" href="/login">Login</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-solid border-indigo-600 rounded hover:bg-indigo-600 hover:text-white transition-colors duration-300 mt-1 md:mt-0 md:ml-1" href="/register">Register</a>
    </div>
  </div>
</nav>
<body class="bg-gray-100">
<div class="flex flex-wrap overflow-hidden xl:-mx-8">
    <div class="w-full overflow-hidden xl:my-8 xl:px-8 text-center m-auto ">
        <h1 class="text-5xl">Wij zijn begonnen in 1890</h1>
        <br>
        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's </br>standard dummy text ever since the 1500s, when an unknown printer took a galley</p>
    </div>
</div>
<br>
<br>

<div class="flex flex-wrap overflow-hidden xl:-mx-5">

  <div class="w-1/6 overflow-hidden xl:my-5 xl:px-5">
  </div>

  <div class="w-1/3 overflow-hidden xl:my-5 xl:px-5">
  <img  src="{{ URL::to('/assets/img/chef2.jpg') }}">
  </div>

  <div class="w-1/3 overflow-hidden xl:my-5 xl:px-5">
  <img  src="{{ URL::to('/assets/img/chef.jpg') }}">
  </div>

  <div class="w-1/6 overflow-hidden xl:my-5 xl:px-5">
  </div>

</div>

</body>
</html>

