<?php

namespace Database\Seeders;

use App\Models\UserOrder;

use Illuminate\Database\Seeder;

class user_order extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        $userRoles = [
            ['user_id' => 1, 'order_id' => 1],
            ['user_id' => 2, 'order_id' => 2],

        ];

        foreach ($userRoles as $userRole) {
            UserOrder::create($userRole);
        }
    }
}
