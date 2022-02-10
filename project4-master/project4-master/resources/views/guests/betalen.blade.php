
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Stonks pizza</title>
    <link href="{{ asset('css/app.css') }}" rel="stylesheet">
</head>
<nav class="bg-white py-2 md:py-4">
  <div class="container px-4 mx-auto md:flex md:items-center">

    <div class="flex justify-between items-center">
    <img class="h-20 w-50" src="{{ URL::to('/assets/img/stonkspizza.jpg') }}">
    </div>
    
    <div class="hidden md:flex flex-col md:flex-row md:ml-auto mt-3 md:mt-0" id="navbar-collapse">
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-200 hover:text-gray-700 transition-colors duration-300" href="/">Home</a>
      <a class="p-2 lg:px-4 md:mx-2 text-white rounded bg-indigo-600" href="/gegevens">Menu</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-400 hover:text-gray-700 transition-colors duration-300" href="/overons" >Over Ons</a>
      <a class="p-2 lg:px-4 md:mx-2 text-gray-600 rounded hover:bg-gray-200 hover:text-gray-700 transition-colors duration-300" href="/Contact">Contact</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-transparent rounded hover:bg-indigo-100 hover:text-indigo-700 transition-colors duration-300" href="/login">Login</a>
      <a class="p-2 lg:px-4 md:mx-2 text-indigo-600 text-center border border-solid border-indigo-600 rounded hover:bg-indigo-600 hover:text-white transition-colors duration-300 mt-1 md:mt-0 md:ml-1" href="/register">Register</a>
    </div>
  </div>
</nav>

<body class="bg-gray-100">
  <div class="container mx-auto mt-10">
    <div class="flex shadow-md my-10">
      <div class="w-3/4 bg-white px-10 py-10">
        <div class="flex justify-between border-b pb-8">
          <h1 class="font-semibold text-2xl">Winkelmandje</h1>
        </div>
        <div class="flex mt-10 mb-5">
          <h3 class="font-semibold text-gray-600 text-base w-2/5">Pizza's</h3>
          <h3 class="font-semibold text-center text-gray-600 text-xs uppercase w-1/5 text-center">Hoeveel</h3>
          <h3 class="font-semibold text-center text-gray-600 text-xs uppercase w-1/5 text-center">Prijs</h3>
          <h3 class="font-semibold text-center text-gray-600 text-xs uppercase w-1/5 text-center">Totaal</h3>
        </div>
      @foreach ($bestelling ->pizzas as $pizza)
        <div class="flex items-center hover:bg-gray-100 -mx-8 px-6 py-5">
          <div class="flex w-2/5"> <!-- product -->
            <div class="flex flex-col justify-between ml-4 flex-grow">
              <span class="font-bold text-sm">Pizza</span>
              <br>  
              <span class=" text-sm">{{$pizza->naam}}</span>  <!-- Naam pizza -->
              <br>
              <form action="{{ route('guests.destroy', ['bestellingid' => $bestelling->id, 'pizzaid' => $pizza->id]) }}" method="POST">
                @csrf
                @method('DELETE')
                <button type="submit" class="font-semibold hover:text-red-500 text-gray-500 text-xs">Verwijder</button>
              </form>  
            </div>
          </div>
          <div class="flex justify-center w-1/5">
            <label>1</label><!-- hoeveel -->
          </div>
          <span class="text-center w-1/5 font-semibold text-sm">€ {{$pizza->prijs}}</span> <!-- Prijs -->
          <span class="text-center w-1/5 font-semibold text-sm">€ {{$pizza->prijs}} </span> <!-- Totaal prijs -->
        </div>
        @endforeach
        <a href="/gegevens/{{$bestelling->id}}/menu" class="flex font-semibold text-indigo-600 text-sm mt-10">
          <svg class="fill-current mr-2 text-indigo-600 w-4" viewBox="0 0 448 512"><path d="M134.059 296H436c6.627 0 12-5.373 12-12v-56c0-6.627-5.373-12-12-12H134.059v-46.059c0-21.382-25.851-32.09-40.971-16.971L7.029 239.029c-9.373 9.373-9.373 24.569 0 33.941l86.059 86.059c15.119 15.119 40.971 4.411 40.971-16.971V296z"/></svg>
          Ga terug naar menu
        </a>
      </div>

      <div id="summary" class="w-1/4 px-8 py-10">
        <h1 class="font-semibold text-2xl border-b pb-8">Afrekenen </h1>
        <div>
          <label class="font-medium inline-block mb-3 text-sm ">Selecteer uw bank</label>
          <select class="block p-2 text-gray-600 w-full text-sm">
            <option>Ing</option>
            <option>Rabobank</option>
            <option>Abn</option>
            <option>Bank</option>
          </select>
        </div>
        <div class="border-t mt-8">
          <div class="flex font-semibold justify-between py-6 text-sm ">
            <span>Totaal</span>
            <span>€ {{$bestelling->totalPrice()}}</span>
          </div>
          <button class="bg-indigo-600 font-semibold py-3 text-sm text-white uppercase w-full">Betalen</button>
        </div>
      </div>

    </div>
  </div>
</body>
