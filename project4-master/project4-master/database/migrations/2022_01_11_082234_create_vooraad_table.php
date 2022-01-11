<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateVooraadTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('vooraad', function (Blueprint $table) {
            $table->id();
            $table->string('ingredient-naam',)->nullable();
            $table->integer('aantal op vooraad',)->nullable();
            $table->double('prijs',)->nullable();
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
        Schema::dropIfExists('vooraad');
    }
}
