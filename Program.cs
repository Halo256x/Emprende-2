using Microsoft.Win32;
using System;
using System.Data;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

< !DOCTYPE html >
< html lang = "es" >
< head >
    < meta charset = "UTF-8" >
    < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
    < title > Emprende + -Plataforma de emprendimientos</title>
    <script src = "https://cdn.tailwindcss.com" ></ script >
    < link rel= "stylesheet" href= "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" >
    < style >
        .category - card:hover {
            transform: translateY(-5px);
box - shadow: 0 10px 20px rgba(0,0,0,0.1);
        }
        .product - card:hover {
            transform: scale(1.02);
box - shadow: 0 5px 15px rgba(0,0,0,0.1);
        }
        #loginModal {
            transition: all 0.3s ease;
        }
        .modal - open {
opacity: 1;
visibility: visible;
}
    </ style >
</ head >
< body class= "bg-gray-50 font-sans" >
    < !--Header-- >
    < header class= "bg-white shadow-md" >
        < nav class= "container mx-auto px-6 py-3" >
            < div class= "flex justify-between items-center" >
                < div class= "flex items-center space-x-8" >
                    < a href = "#" class= "text-2xl font-bold text-indigo-600" >
                        < span class= "text-indigo-800" > Emprende </ span >< span class= "text-indigo-500" > +</ span >
                    </ a >
                    < div class= "hidden md:flex space-x-8" >
                        < a href = "#" class= "text-gray-700 hover:text-indigo-600" > Inicio </ a >
                        < a href = "#categories" class= "text-gray-700 hover:text-indigo-600" > Categorías </ a >
                        < a href = "#products" class= "text-gray-700 hover:text-indigo-600" > Emprendimientos </ a >
                        < a href = "#contact" class= "text-gray-700 hover:text-indigo-600" > Contacto </ a >
                    </ div >
                </ div >
                < div class= "flex items-center space-x-4" >
                    < button id = "loginBtn" class= "px-4 py-2 bg-indigo-600 text-white rounded-md hover:bg-indigo-700 transition" >
                        Iniciar sesión
                    </ button >
                    < button class= "md:hidden" id = "mobileMenuBtn" >
                        < i class= "fas fa-bars text-gray-700 text-xl" ></ i >
                    </ button >
                </ div >
            </ div >
            < !--Mobile menu-- >
            < div class= "md:hidden hidden mt-4" id = "mobileMenu" >
                < a href = "#" class= "block py-2 text-gray-700 hover:text-indigo-600" > Inicio </ a >
                < a href = "#categories" class= "block py-2 text-gray-700 hover:text-indigo-600" > Categorías </ a >
                < a href = "#products" class= "block py-2 text-gray-700 hover:text-indigo-600" > Emprendimientos </ a >
                < a href = "#contact" class= "block py-2 text-gray-700 hover:text-indigo-600" > Contacto </ a >
            </ div >
        </ nav >
    </ header >

    < !--Hero Section-- >
    < section class= "bg-gradient-to-r from-indigo-500 to-purple-600 text-white py-20" >
        < div class= "container mx-auto px-6 text-center" >
            < h1 class= "text-5xl font-bold mb-6" > Conectamos emprendedores con el mundo</h1>
            <p class= "text-xl mb-8" > Descubre y apoya los mejores emprendimientos locales en un solo lugar</p>
            <div class= "flex justify-center space-x-4" >
                < a href = "#categories" class= "px-6 py-3 bg-white text-indigo-600 font-semibold rounded-md hover:bg-gray-100 transition" > Explorar categorías </ a >
                < a href = "#products" class= "px-6 py-3 border-2 border-white text-white font-semibold rounded-md hover:bg-white hover:text-indigo-600 transition" > Ver emprendimientos </ a >
            </ div >
        </ div >
    </ section >

    < !--Categories Section-- >
    < section id = "categories" class= "py-16 bg-white" >
        < div class= "container mx-auto px-6" >
            < h2 class= "text-3xl font-bold text-center mb-12 text-gray-800" > Explora por categorías</h2>
            <div class= "grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-8" >
                < !--Category 1-- >
                < div class= "category-card bg-white rounded-lg overflow-hidden shadow-md transition duration-300" >
                    < div class= "h-48 bg-gray-100 overflow-hidden" >
                        < img src = "https://storage.googleapis.com/workspace-0f70711f-8b4e-4d94-86f1-2a93ccde5887/image/8a4ab02f-d0f8-41bf-9ec9-7124fb773705.png" alt = "Diversos productos alimenticios artesanales incluyendo mermeladas, panes y quesos en una mesa de madera rústica" class= "w-full h-full object-cover" >
                    </ div >
                    < div class= "p-6" >
                        < h3 class= "text-xl font-semibold text-gray-800 mb-2" > Alimentos </ h3 >
                        < p class= "text-gray-600" > Productos artesanales y gourmet</p>
                    </div>
                </div>

                <!-- Category 2 -->
                <div class= "category-card bg-white rounded-lg overflow-hidden shadow-md transition duration-300" >
                    < div class= "h-48 bg-gray-100 overflow-hidden" >
                        < img src = "https://storage.googleapis.com/workspace-0f70711f-8b4e-4d94-86f1-2a93ccde5887/image/2915f78a-88d8-4a9e-a88b-e728d2f6f8d3.png" alt = "Variedad de artículos de moda sostenible incluyendo ropa, accesorios y joyería organizados en estantes" class= "w-full h-full object-cover" >
                    </ div >
                    < div class= "p-6" >
                        < h3 class= "text-xl font-semibold text-gray-800 mb-2" > Moda </ h3 >
                        < p class= "text-gray-600" > Estilo sostenible y único</p>
                    </div>
                </div>

                <!-- Category 3 -->
                <div class= "category-card bg-white rounded-lg overflow-hidden shadow-md transition duration-300" >
                    < div class= "h-48 bg-gray-100 overflow-hidden" >
                        < img src = "https://storage.googleapis.com/workspace-0f70711f-8b4e-4d94-86f1-2a93ccde5887/image/5b8e9682-bdbd-4a4d-a2fc-7a94aa19b766.png" alt = "Decoración para el hogar con elementos artesanales, velas y textiles étnicos en un ambiente iluminado" class= "w-full h-full object-cover" >
                    </ div >
                    < div class= "p-6" >
                        < h3 class= "text-xl font-semibold text-gray-800 mb-2" > Hogar </ h3 >
                        < p class= "text-gray-600" > Decoración y artículos para el hogar</p>
                    </div>
                </div>

                <!-- Category 4 -->
                <div class= "category-card bg-white rounded-lg overflow-hidden shadow-md transition duration-300" >
                    < div class= "h-48 bg-gray-100 overflow-hidden" >
                        < img src = "https://storage.googleapis.com/workspace-0f70711f-8b4e-4d94-86f1-2a93ccde5887/image/2a56bbca-1ad0-41a6-8745-c456020aa72f.png" alt = "Tecnología y gadgets innovadores incluidos drones, auriculares y dispositivos inteligentes sobre fondo negro" class= "w-full h-full object-cover" >
                    </ div >
                    < div class= "p-6" >
                        < h3 class= "text-xl font-semibold text-gray-800 mb-2" > Tecnología </ h3 >
                        < p class= "text-gray-600" > Innovación y gadgets únicos</p>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- Featured Products Section -->
    <section id="products" class= "py-16 bg-gray-50" >
        < div class= "container mx-auto px-6" >
            < h2 class= "text-3xl font-bold text-center mb-12 text-gray-800" > Emprendimientos destacados </ h2 >
            < div class= "grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-8" >
                < !--Product 1-- >
                < div class= "product-card bg-white rounded-lg overflow-hidden shadow-md transition duration-300" >
                    < div class= "h-64 bg-gray-100 overflow-hidden" >
                        < img src = "https://storage.googleapis.com/workspace-0f70711f-8b4e-4d94-86f1-2a93ccde5887/image/c6ff90e0-2cdc-49b8-b091-443eaa45cb57.png" alt = "Mermeladas artesanales de diversos sabores con etiquetas creativas en frascos de vidrio sobre mesa de madera" class= "w-full h-full object-cover" >
                    </ div >
                    < div class= "p-6" >
                        < span class= "inline-block px-3 py-1 text-xs font-semibold bg-indigo-100 text-indigo-800 rounded-full mb-2" > Alimentos </ span >
                        < h3 class= "text-xl font-semibold text-gray-800 mb-2" > Dulces del Valle</h3>
                        <p class= "text-gray-600 mb-4" > Mermeladas artesanales hechas con frutas locales y sin conservantes.</p>
                        <div class= "flex items-center mb-4" >
                            < div class= "flex items-center text-yellow-400" >
                                < i class= "fas fa-star" ></ i >
                                < i class= "fas fa-star" ></ i >
                                < i class= "fas fa-star" ></ i >
                                < i class= "fas fa-star" ></ i >
                                < i class= "fas fa-star-half-alt" ></ i >
                            </ div >
                            < span class= "ml-2 text-gray-600" > 4.5(128) </ span >
                        </ div >
                        < div class= "mt-4" >
                            < h4 class= "font-semibold text-gray-700 mb-2" > Contacto:</ h4 >
                            < p class= "text-gray-600" >< i class= "fas fa-phone mr-2" ></ i > +57 300 123 4567 </ p >
                            < p class= "text-gray-600" >< i class= "fas fa-envelope mr-2" ></ i > dulcesdelvalle@gmail.com </ p >
                        </ div >
                        < button class= "mt-4 w-full py-2 bg-indigo-600 text-white rounded-md hover:bg-indigo-700 transition" > Ver detalles </ button >
                    </ div >
                </ div >

                < !--Product 2-- >
                < div class= "product-card bg-white rounded-lg overflow-hidden shadow-md transition duration-300" >
                    < div class= "h-64 bg-gray-100 overflow-hidden" >
                        < img src = "https://storage.googleapis.com/workspace-0f70711f-8b4e-4d94-86f1-2a93ccde5887/image/276e5be7-38d2-43af-91a0-d7cad2514bcc.png" alt = "Bolsos y carteras de cuero artesanales en tonos tierra exhibidos en estante de madera natural" class= "w-full h-full object-cover" >
                    </ div >
                    < div class= "p-6" >
                        < span class= "inline-block px-3 py-1 text-xs font-semibold bg-indigo-100 text-indigo-800 rounded-full mb-2" > Moda </ span >
                        < h3 class= "text-xl font-semibold text-gray-800 mb-2" > Estilo Nativo </ h3 >
                        < p class= "text-gray-600 mb-4" > Accesorios de cuero sustentable hechos a mano por artesanos locales.</p>
                        <div class= "flex items-center mb-4" >
                            < div class= "flex items-center text-yellow-400" >
                                < i class= "fas fa-star" ></ i >
                                < i class= "fas fa-star" ></ i >
                                < i class= "fas fa-star" ></ i >
                                < i class= "fas fa-star" ></ i >
                                < i class= "far fa-star" ></ i >
                            </ div >
                            < span class= "ml-2 text-gray-600" > 4.0(96) </ span >
                        </ div >
                        < div class= "mt-4" >
                            < h4 class= "font-semibold text-gray-700 mb-2" > Contacto:</ h4 >
                            < p class= "text-gray-600" >< i class= "fas fa-phone mr-2" ></ i > +57 310 987 6543 </ p >
                            < p class= "text-gray-600" >< i class= "fas fa-envelope mr-2" ></ i > estilonativo@gmail.com </ p >
                        </ div >
                        < button class= "mt-4 w-full py-2 bg-indigo-600 text-white rounded-md hover:bg-indigo-700 transition" > Ver detalles </ button >
                    </ div >
                </ div >

                < !--Product 3-- >
                < div class= "product-card bg-white rounded-lg overflow-hidden shadow-md transition duration-300" >
                    < div class= "h-64 bg-gray-100 overflow-hidden" >
                        < img src = "https://storage.googleapis.com/workspace-0f70711f-8b4e-4d94-86f1-2a93ccde5887/image/b53cdb7f-01db-4ef6-8425-2a3444436d90.png" alt = "Dispositivo electrónico portátil con diseño minimalista sobre escritorio moderno con luces cálidas" class= "w-full h-full object-cover" >
                    </ div >
                    < div class= "p-6" >
                        < span class= "inline-block px-3 py-1 text-xs font-semibold bg-indigo-100 text-indigo-800 rounded-full mb-2" > Tecnología </ span >
                        < h3 class= "text-xl font-semibold text-gray-800 mb-2" > TechArt </ h3 >
                        < p class= "text-gray-600 mb-4" > Gadgets innovadores diseñados para simplificar tu vida diaria.</p>
                        <div class= "flex items-center mb-4" >
                            < div class= "flex items-center text-yellow-400" >
                                < i class= "fas fa-star" ></ i >
                                < i class= "fas fa-star" ></ i >
                                < i class= "fas fa-star" ></ i >
                                < i class= "fas fa-star" ></ i >
                                < i class= "fas fa-star" ></ i >
                            </ div >
                            < span class= "ml-2 text-gray-600" > 5.0(210) </ span >
                        </ div >
                        < div class= "mt-4" >
                            < h4 class= "font-semibold text-gray-700 mb-2" > Contacto:</ h4 >
                            < p class= "text-gray-600" >< i class= "fas fa-phone mr-2" ></ i > +57 315 456 7890 </ p >
                            < p class= "text-gray-600" >< i class= "fas fa-envelope mr-2" ></ i > techart.innovaciones@gmail.com </ p >
                        </ div >
                        < button class= "mt-4 w-full py-2 bg-indigo-600 text-white rounded-md hover:bg-indigo-700 transition" > Ver detalles </ button >
                    </ div >
                </ div >
            </ div >
        </ div >
    </ section >

    < !--Call to Action -->
    <section class= "py-16 bg-indigo-700 text-white" >
        < div class= "container mx-auto px-6 text-center" >
            < h2 class= "text-3xl font-bold mb-6" >¿Eres emprendedor?</h2>
            <p class= "text-xl mb-8" > Registra tu negocio en nuestra plataforma y llega a más clientes</p>
            <button class= "px-6 py-3 bg-white text-indigo-700 font-semibold rounded-md hover:bg-gray-100 transition" >
                Registrar mi emprendimiento
            </button>
        </div>
    </section>

    <!-- Footer -->
    <footer id = "contact" class= "bg-gray-900 text-white py-12" >
        < div class= "container mx-auto px-6" >
            < div class= "grid grid-cols-1 md:grid-cols-3 gap-8" >
                < div >
                    < h3 class= "text-xl font-bold mb-4" > Emprende +</ h3 >
                    < p class= "text-gray-400" > Conectando emprendedores con el mundo desde 2023.</p>
                </div>
                <div>
                    <h3 class= "text-xl font-bold mb-4" > Contacto </ h3 >
                    < p class= "text-gray-400 mb-2" >< i class= "fas fa-map-marker-alt mr-2" ></ i > Bogotá, Colombia </ p >
                    < p class= "text-gray-400 mb-2" >< i class= "fas fa-phone mr-2" ></ i > +57 1 123 4567 </ p >
                    < p class= "text-gray-400" >< i class= "fas fa-envelope mr-2" ></ i > hola@emprendeplus.com </ p >
                </ div >
                < div >
                    < h3 class= "text-xl font-bold mb-4" > Síguenos </ h3 >
                    < div class= "flex space-x-4" >
                        < a href = "#" class= "text-gray-400 hover:text-white" >< i class= "fab fa-facebook-f" ></ i ></ a >
                        < a href = "#" class= "text-gray-400 hover:text-white" >< i class= "fab fa-twitter" ></ i ></ a >
                        < a href = "#" class= "text-gray-400 hover:text-white" >< i class= "fab fa-instagram" ></ i ></ a >
                        < a href = "#" class= "text-gray-400 hover:text-white" >< i class= "fab fa-linkedin-in" ></ i ></ a >
                    </ div >
                </ div >
            </ div >
            < div class= "border-t border-gray-800 mt-8 pt-8 text-center text-gray-400" >
                < p >© 2023 Emprende +.Todos los derechos reservados.</p>
            </div>
        </div>
    </footer>

    <!-- Login Modal -->
    <div id="loginModal" class= "fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50 opacity-0 invisible" >
        < div class= "bg-white rounded-lg p-8 w-full max-w-md mx-4" >
            < div class= "flex justify-between items-center mb-6" >
                < h3 class= "text-2xl font-bold text-gray-800" > Iniciar sesión </ h3 >
                < button id = "closeModal" class= "text-gray-500 hover:text-gray-700" >
                    < i class= "fas fa-times" ></ i >
                </ button >
            </ div >
            < form id = "loginForm" >
                < div class= "mb-4" >
                    < label for= "email" class= "block text-gray-700 mb-2" > Correo electrónico </ label >
                    < input type = "email" id = "email" class= "w-full px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-indigo-500" required >
                </ div >
                < div class= "mb-6" >
                    < label for= "password" class= "block text-gray-700 mb-2" > Contraseña </ label >
                    < input type = "password" id = "password" class= "w-full px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-indigo-500" required >
                </ div >
                < button type = "submit" class= "w-full bg-indigo-600 text-white py-2 rounded-md hover:bg-indigo-700 transition mb-4" > Iniciar sesión </ button >
                < div class= "text-center" >
                    < a href = "#" class= "text-indigo-600 hover:text-indigo-800" >¿Olvidaste tu contraseña?</a>
                </div>
            </form>
        </div>
    </div>

    <!-- Success Message -->
    <div id="successMessage" class= "fixed top-4 right-4 bg-green-100 border border-green-400 text-green-700 px-4 py-3 rounded hidden max-w-xs" role = "alert" >
        < div class= "flex items-center" >
            < i class= "fas fa-check-circle mr-2" ></ i >
            < span class= "block sm:inline" >¡Inicio de sesión exitoso!</span>
        </div>
    </div>

    <script>
        // Mobile menu toggle
        document.getElementById('mobileMenuBtn').addEventListener('click', function() {
            const menu = document.getElementById('mobileMenu');
menu.classList.toggle('hidden');
        });

// Login modal functionality
const loginBtn = document.getElementById('loginBtn');
const closeModal = document.getElementById('closeModal');
const loginModal = document.getElementById('loginModal');
const loginForm = document.getElementById('loginForm');
const successMessage = document.getElementById('successMessage');

loginBtn.addEventListener('click', function() {
    loginModal.classList.add('modal-open');
    loginModal.classList.remove('invisible', 'opacity-0');
});

closeModal.addEventListener('click', function() {
    loginModal.classList.remove('modal-open');
    loginModal.classList.add('invisible', 'opacity-0');
});

loginForm.addEventListener('submit', function(e) {
    e.preventDefault();
    // Here you would typically send the data to a server
    // For demo purposes, we'll just show a success message
    loginModal.classList.remove('modal-open');
    loginModal.classList.add('invisible', 'opacity-0');

    successMessage.classList.remove('hidden');
    setTimeout(() => {
        successMessage.classList.add('hidden');
    }, 3000);
});

// Close modal when clicking outside
loginModal.addEventListener('click', function(e) {
    if (e.target === loginModal)
    {
        loginModal.classList.remove('modal-open');
        loginModal.classList.add('invisible', 'opacity-0');
    }
});
    </ script >
</ body >
</ html >

