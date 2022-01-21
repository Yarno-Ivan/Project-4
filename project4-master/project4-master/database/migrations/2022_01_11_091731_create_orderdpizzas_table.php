<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateOrderdpizzasTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('orderdpizzas', function (Blueprint $table) {

            $table->unsignedBigInteger('bestelling_id')->index();
            $table->unsignedBigInteger('pizza_id')->index();


            $table->foreign('bestelling_id')->references('id')->on('bestellingen');
            $table->foreign('pizza_id')->references('id')->on('pizzas');

            $table->primary(['bestelling_id', 'pizza_id']);
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('orderdpizzas');
    }
}
