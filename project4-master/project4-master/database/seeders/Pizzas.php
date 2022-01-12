<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Carbon\Carbon;
class Pizzas extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table('Pizzas')->insert([
            'naam' => 'Magaritha',
            'info' => 'geen',
            'prijs' => '10',
            'created_at' => Carbon::now(),
            'updated_at' => Carbon::tomorrow(),
        ]);
    }
}
