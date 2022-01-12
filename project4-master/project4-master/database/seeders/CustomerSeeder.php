<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;

class CustomerSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        Pizzas::create([
            'naam' => 'Magaritha',
            'info' => 'geen',
            'prijs' => '10',
            'created_at' => Carbon::now(),
            'updated_at' => Carbon::tomorrow(),
        ]);
    }
}
