<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Carbon\Carbon;
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
            'naam' => 'kaas',
            'aantal op vooraad' => '100',
            'prijs' => '10.20',
            'created_at' => Carbon::now(),
            'updated_at' => Carbon::tomorrow()
        ]);
    }
}

