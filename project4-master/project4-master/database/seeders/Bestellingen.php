<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Carbon\Carbon;
class Bestellingen extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table('bestellingen')->insert([
            'id-klant' => '1',
            'totaalprijs' => '10',
            'status' => 'Besteld',
        ]);
        DB::table('bestellingen')->insert([
            'id-klant' => '2',
            'totaalprijs' => '11',
            'status' => 'Besteld',
        ]);
    }
}
