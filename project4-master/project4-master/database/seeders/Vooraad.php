<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;

class Vooraad extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table('vooraad')->insert([
            'name' => 'the baby girl song',
            'year' => '1970',
            'times_sold' => '145',
            'created_at' => Carbon::now(),
            'updated_at' => Carbon::tomorrow()
        ]);
    }
}
