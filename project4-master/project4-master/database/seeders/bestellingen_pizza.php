<?php

namespace Database\Seeders;
use App\Models\orderdpizzas;
use Illuminate\Database\Seeder;

class orderdpizza extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        $bestellingpizza = [
            ['bestelling_id' => 1, 'pizza_id' => 1],
            ['bestelling_id' => 1, 'pizza_id' => 2],
            ['bestelling_id' => 2, 'pizza_id' => 2],
            ['bestelling_id' => 2, 'pizza_id' => 1],

        ];
        foreach ($bestellingpizza as $bestellingpizza) {
            orderdpizzas::create($bestellingpizza);
        }
    }
}
