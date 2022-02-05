<?php

namespace App\Http\Controllers;

use App\Models\User;
use App\Models\Pizzas;
use App\Models\Bestellingen;
use App\Models\orderdpizzas;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class PizzasController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return view("guests.menu", ['pizzas' => Pizzas::all()]);
    }


    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request, $bestellingid , $pizzaid)
    {
        $bestelling = Bestellingen::find($bestellingid);
        $pizza = Pizzas::find($pizzaid);
        $request->session()->flash('success', 'Form has been saved');
        Bestellingen::find($bestellingid)->Pizzas()->attach($pizzaid);
        return redirect()->route('guests.menu',['bestellingen' => $bestelling, 'pizzas' => Pizzas::all()]);
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        
        return view("guests.menu", ['bestellingen' => Bestellingen::find($id),'pizzas' => Pizzas::all()]);
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        return view("guests.edit", ['pizzas' => Pizzas::find($id)]);
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        Pizzas::find($id)->update($request->except(['id', '_token']));
        return redirect()->route('guests.menu');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
    }
}
