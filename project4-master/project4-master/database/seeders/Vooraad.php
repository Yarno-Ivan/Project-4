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
            'naam' => 'tomatensaus',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'Ui',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'geraspte kaas',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'knoflook',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'tomaten',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'mozarella',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'champignons',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'ham',
            'aantal' => '1',
        ]);
        DB::table('vooraad')->insert([
            'naam' => 'Gedroogde oregano',
            'aantal' => '1',
        ]);

    }
}

