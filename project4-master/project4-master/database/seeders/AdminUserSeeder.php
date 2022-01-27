<?php

namespace Database\Seeders;

use App\Models\User;
use Illuminate\Database\Seeder;

class AdminUserSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        User::create([
        'id' => '1',
            'name' => 'samira',
            'back_name'=>'van hender',
            'email' => 'samira@pizzasumma.nl',
            'password' => bcrypt('password'),
            'address' => 'adres 1',
            'phone'=>'0612345678',
            'zipcode'=>'1234 AB',
            'city' =>'stad 1',
            'pizza_points'=>'0',
        ]);
    }
}
