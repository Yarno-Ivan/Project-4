<?php

use App\Http\Controllers\AdminController;
use App\Http\Controllers\CustomerController;
use App\Http\Controllers\EmployeeController;
use App\Http\Controllers\RoleController;
use App\Http\Controllers\UserController;
use App\Http\Controllers\PizzasController;
use App\Http\Controllers\GegevensController;
use App\Http\Controllers\BetalenController;
use App\Models\User;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});
Route::get('/index', function () {
    return view('customers.index');
});
Route::get('/', function () {
    return view('guests.index');
});
Route::get('/Contact', function () {
    return view('guests.contact');
});
Route::get('/overons', function () {
    return view('guests.overons');
});

Route::get('/gegevens', [GegevensController::class, 'index'])->name('guests.Gegevens');
Route::post('/gegevens', [GegevensController::class, 'store'])->name('guests.store');
Route::get('/gegevens/{bestellingen}/menu', [PizzasController::class, 'show'])->name('guests.menu');
Route::post('/gegevens/{bestellingid}/menu/{pizzaid}', [PizzasController::class, 'store'])->name('pizza.store');
Route::get('/betalen/{bestellingid}', [BetalenController::class, 'show'])->name('guests.betalen');
//Route::get('/menu/{id}/edit', [PizzasController::class, 'edit'])->name('guests.aanpassen');
//Route::put('/menu/{id}', [PizzasController::class, 'update'])->name('guests.update');

Route::group(['middleware'=>'auth'], function(){
    Route::get('/dashboard', function () {
        return view('dashboard');
    })->name('dashboard');
    Route::get('/admin', [AdminController::class, 'index'])->name('admin.index');
    Route::get('/admin/resetpassword/{id}', [AdminController::class, 'resetpassword'])->name('admin.resetpassword');
    Route::put('/admin/updatepassword/{id}', [AdminController::class, 'updatepassword'])->name('admin.updatepassword');
    Route::resource('role', RoleController::class);
    Route::resource('user', UserController::class);
    Route::resource('employee', EmployeeController::class);
    Route::resource('customer', CustomerController::class);
});


require __DIR__.'/auth.php';
