<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use App\Models\Pizzas;

class winkelmandpizza extends Model
{
    use HasFactory;

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'winkelmand_pizza';

    /**
     * Indicates if the model should be timestamped.
     *
     * @var bool
     */
    public $timestamps = false;

    protected $fillable = [
        'pizza_id',
        'winkelmand_id',
        'user_id'
    ];
    public function pizza(){
        return $this->belongsTo(Pizza::class);
    }
}
