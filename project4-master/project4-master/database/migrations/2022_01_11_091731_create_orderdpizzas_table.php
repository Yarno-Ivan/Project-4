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
        Schema::create('bestellingen_pizzas', function (Blueprint $table) {

            $table->unsignedBigInteger('bestellingen_id')->index();
            $table->unsignedBigInteger('pizzas_id')->index();


            $table->foreign('bestellingen_id')->references('id')->on('bestellingen');
            $table->foreign('pizzas_id')->references('id')->on('pizzas');

            $table->primary(['bestellingen_id', 'pizzas_id']);
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('bestellingen_pizzas');
    }
}
