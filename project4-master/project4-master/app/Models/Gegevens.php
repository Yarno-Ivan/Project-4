<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Gegevens extends Model
{
    use HasFactory;
            /**
     * The attributes that are mass assignable.
     *
     * @var string[]
     */
    protected $fillable = [];

    
      /**
     * Indicates if the model should be timestamped.
     *
     * @var bool
     */
    public $timestamps = false;
    /**
     * The attributes that aren't mass assignable.
     *
     * @var string[]|bool
     */
    protected $guarded = ['*', 'id'];
        /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = "bestellingen";
}
