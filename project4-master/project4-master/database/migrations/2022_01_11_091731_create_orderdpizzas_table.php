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
            $table->id();
            $table->integer('bestelling_id')->nullable();
            $table->string('naam')->nullable();
            $table->string('grote')->nullable();
            $table->string('extra-opmerking')->nullable();
            $table->timestamps();
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
