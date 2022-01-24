<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateWinkelmandjePizzas extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('Winkelmand_Pizza', function (Blueprint $table) {
            $table->unsignedBigInteger('pizza_id')->index();
            $table->unsignedBigInteger('winkelmand_id')->index();
            $table->unsignedBigInteger('user_id')->index();

            $table->foreign('user_id')->references('id')->on('users');
            $table->foreign('pizza_id')->references('id')->on('pizzas');
            $table->foreign('winkelmand_id')->references('id')->on('winkelmandje');

            $table->primary(['pizza_id', 'winkelmand_id','user_id']);
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('Winkelmand_Pizza');
    }
}
