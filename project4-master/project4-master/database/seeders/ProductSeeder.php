<?php

namespace Database\Seeders;

use App\Models\Product;
use Illuminate\Database\Seeder;

class ProductSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        Product::create([
            'name' => 'Fungi',
            'price' => 1000,
        ]);
        Product::create([
            'name' => 'Salami',
            'price' => 5000,
        ]);
        Product::create([
            'name' => 'Magaritha',
            'price' => 5000,
        ]);
        Product::create([
            'name' => 'iets',
            'price' => 80000,
        ]);
    }
}
