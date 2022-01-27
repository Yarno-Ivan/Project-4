<?php

namespace Database\Seeders;

use App\Models\User;
use Illuminate\Database\Seeder;

class UserSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        User::create([
            'id' => '2',
            'name' => 'peter',
            'back_name' => 'baksteen',
            'email' => 'peter@pizzasumma.nl',
            'password' => bcrypt('password'),
            'address' => 'adres 1',
            'phone'=>'0612345678',
            'zipcode'=>'1234 AB',
            'city' =>'stad 1',
            'pizza_points'=>'0',
            ]);
        User::create([
            'id' => '3',
            'name' => 'mohammed',
            'back_name' => 'mootje',
            'email' => 'mohammed@pizzasumma.nl',
            'password' => bcrypt('password'),
            'address' => 'adres 1',
            'phone'=>'0612345678',
            'zipcode'=>'1234 AB',
            'city' =>'stad 1',
            'pizza_points'=>'0',
        ]);
        User::create([
            'id' => '4',
            'name' => 'ginny',
            'back_name' => 'de heks',
            'email' => 'ginny@pizzasumma.nl',
            'password' => bcrypt('password'),
            'address' => 'adres 1',
            'phone'=>'0612345678',
            'zipcode'=>'1234 AB',
            'city' =>'stad 1',
            'pizza_points'=>'0',
        ]);
        User::create([
            'id' => '5',
            'name' => 'michelle',
            'back_name' => 'de lang',
            'email' => 'michelle@pizzasumma.nl',
            'password' => bcrypt('password'),
            'address' => 'adres 1',
            'phone'=>'0612345678',
            'zipcode'=>'1234 AB',
            'city' =>'stad 1',
            'pizza_points'=>'0',
        ]);
        User::create([
            'id' => '6',
            'name' => 'Hamza',
            'back_name' => 'Al-Hussein',
            'email' => 'hah@test.test',
            'password' => bcrypt('password'),
            'address' => 'adres 1',
            'phone'=>'0612345678',
            'zipcode'=>'1234 AB',
            'city' =>'stad 1',
            'pizza_points'=>'0',
        ]);
        User::create([
            'id' => '7',
            'name' => 'Koen',
            'back_name' => 'van der Velden',
            'email' => 'kvv@test.test',
            'password' => bcrypt('password'),
            'address' => 'adres 1',
            'phone'=>'0612345678',
            'zipcode'=>'1234 AB',
            'city' =>'stad 1',
            'pizza_points'=>'0',
        ]);
        User::create([
            'id' => '8',
            'name' => 'Ilse',
            'back_name' => 'Gijsbrechts',
            'email' => 'ig@test.test',
            'password' => bcrypt('password'),
            'address' => 'adres 1',
            'phone'=>'0612345678',
            'zipcode'=>'1234 AB',
            'city' =>'stad 1',
            'pizza_points'=>'0',
        ]);
    }
}
