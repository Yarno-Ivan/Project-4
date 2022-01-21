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
            'naam' => 'Brood 25cm',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'Brood 30cm',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'Brood 35cm',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'Kaas',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'TomatenSaus',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'Ananas',
            'aantal' => '1',
        ]);
    }
}

