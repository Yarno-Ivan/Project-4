
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
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-200 hover:text-gray-700 transition-colors duration-300 "href="/">Home</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-200 hover:text-gray-700 transition-colors duration-300" href="/gegevens">Menu</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-400 hover:text-gray-700 transition-colors duration-300" href="/overons">Over Ons</a>
      <a class="p-2 lg:px-4 md:mx-2 text-white rounded bg-indigo-600" href="/Contact">Contact</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-transparent rounded hover:bg-indigo-100 hover:text-indigo-700 transition-colors duration-300" href="/login">Login</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-solid border-indigo-600 rounded hover:bg-indigo-600 hover:text-white transition-colors duration-300 mt-1 md:mt-0 md:ml-1" href="/register">Register</a>
    </div>
  </div>
</nav>
<body class="bg-gray-100">
    <div class="flex flex-wrap overflow-hidden w-8/12 mt-20 m-auto">
        <div class="w-1/2 overflow-hidden ">
        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d9942.336196737679!2d5.481423392990203!3d51.465792974051595!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47c6d8d46a1fd9a7%3A0x2683f0238844f87a!2sSumma%20College!5e0!3m2!1sen!2snl!4v1643011843165!5m2!1sen!2snl" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
        </div>
        <div class="w-1/2 overflow-hidden ">
        <div>
            <span class="uppercase text-sm text-gray-600 font-bold">Volledige Naam</span>
            <input class="w-full text-gray-900 mt-2 p-3 focus:outline-none focus:shadow-outline"
              type="text" placeholder="">
          </div>
          <div class="mt-8">
            <span class="uppercase text-sm text-gray-600 font-bold">Email</span>
            <input class="w-full text-gray-900 mt-2 p-3 focus:outline-none focus:shadow-outline"
              type="text">
          </div>
          <div class="mt-8">
            <span class="uppercase text-sm text-gray-600 font-bold">Bericht</span>
            <textarea
              class="w-full h-32  text-gray-900 mt-2 p-3focus:outline-none focus:shadow-outline"></textarea>
          </div>
          <div class="mt-8">
            <button
              class="uppercase text-sm font-bold tracking-wide bg-indigo-600 text-gray-100 p-3 rounded-lg w-full focus:outline-none focus:shadow-outline">
              Verstuur Vraag
            </button> 
          </div>

        </div>
    </div>

</div>
</body>
</html>



