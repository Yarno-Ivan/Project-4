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
            ['pizza_id' => 1, 'vooraad_id' => 2],
            ['pizza_id' => 1, 'vooraad_id' => 4],
            ['pizza_id' => 1, 'vooraad_id' => 9],
            ['pizza_id' => 1, 'vooraad_id' => 8],
            ['pizza_id' => 1, 'vooraad_id' => 7],
            ['pizza_id' => 1, 'vooraad_id' => 5],

            ['pizza_id' => 2, 'vooraad_id' => 2],
            ['pizza_id' => 2, 'vooraad_id' => 4],
            ['pizza_id' => 2, 'vooraad_id' => 10],
            ['pizza_id' => 2, 'vooraad_id' => 11],
            ['pizza_id' => 2, 'vooraad_id' => 6],
            ['pizza_id' => 2, 'vooraad_id' => 12],
        ];

        foreach ($Pizzaingredient as $Pizzaingredient) {
            Pizzavooraad::create($Pizzaingredient);
        }
    }
}
