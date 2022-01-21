<?php

namespace Database\Seeders;
use App\Models\Pizzavooraad;
use Illuminate\Database\Seeder;

class Pizza_Vooraad extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        $Pizzaingredient = [
            ['pizza_id' => 1, 'vooraad_id' => 1],
            ['pizza_id' => 1, 'vooraad_id' => 4],
            ['pizza_id' => 1, 'vooraad_id' => 5],
            ['pizza_id' => 1, 'vooraad_id' => 6],

        ];

        foreach ($Pizzaingredient as $Pizzaingredient) {
            Pizzavooraad::create($Pizzaingredient);
        }
    }
}
