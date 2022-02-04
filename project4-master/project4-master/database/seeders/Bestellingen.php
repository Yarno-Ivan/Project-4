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
            'naam' => 'henk',
            'adress' => 'ergensopstraatbuiten',
            'email' => 'henk@water.com',
            'status' => 'Besteld',
        ]);
        DB::table('bestellingen')->insert([
            'naam' => 'henk',
            'adress' => 'ergensopstraat',
            'email' => 'h@waters.nl',
            'status' => 'Besteld',
        ]);
    }
}
