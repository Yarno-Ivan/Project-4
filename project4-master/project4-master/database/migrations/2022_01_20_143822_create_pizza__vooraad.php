<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreatePizzaVooraad extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('pizza_vooraad', function (Blueprint $table) {

            $table->unsignedBigInteger('pizza_id')->index();
            $table->unsignedBigInteger('vooraad_id')->index();

            $table->primary(['pizza_id', 'vooraad_id']);
            $table->foreign('pizza_id')->references('id')->on('pizzas');
            $table->foreign('vooraad_id')->references('id')->on('vooraad');

        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('pizza_vooraad');
    }
}
