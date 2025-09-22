// Sincronizar las letras con la canción
var audio = document.querySelector("audio");
var lyrics = document.querySelector("#lyrics");

// Array de objetos que contiene cada línea y su tiempo de aparición en segundos
var lyricsData = [
    { text: "Y ahora quiero que vuelvas, como un niño los finde'", time: 0.0, estimated: true },
    { text: "Desde que te has ido, no hacen gracia los chiste'", time: 3.1, estimated: true },
    { text: "Me he cortado el pelo, me he comprado otro tinte", time: 7.0, estimated: true },
    { text: "Buscando a ver si encuentro alguna como tú en Tinder", time: 11.0, estimated: true },
    { text: "Mi niña, eres la musa de mis canciones tristes", time: 15.5, estimated: true },
    { text: "No puedo cerrar los ojos, mientras te me desvistes", time: 20.0, estimated: true },
    { text: "Haces que de mí se vayan to' mis despiste'", time: 24.0, estimated: true },
    { text: "Y es que olvidarte no será una tarea simple", time: 30.0, estimated: true }
  ];

// Animar las letras
function updateLyrics() {
  var time = audio.currentTime;
  var currentLine = lyricsData.find(
    (line) => time >= line.time && time < line.time + 6  // Duración de cada línea en segundos
  );

  if (currentLine) {
    // Calcula la opacidad basada en el tiempo en la línea actual
    var fadeInDuration = 0.1; // Duración del efecto de aparición en segundos
    var opacity = Math.min(1, (time - currentLine.time) / fadeInDuration);

    // Aplica el efecto de aparición
    lyrics.style.opacity = opacity;
    lyrics.innerHTML = currentLine.text;
  } else {
    // Restablece la opacidad y el contenido si no hay una línea actual
    lyrics.style.opacity = 0;
    lyrics.innerHTML = "";
  }
}

setInterval(updateLyrics, 100);

//funcion titulo
// Función para ocultar el título después de 216 segundos
function ocultarTitulo() {
  var titulo = document.querySelector(".titulo");
  titulo.style.animation =
    "fadeOut 3s ease-in-out forwards"; /* Duración y función de temporización de la desaparición */
  setTimeout(function () {
    titulo.style.display = "none";
  }, 3000); // Espera 3 segundos antes de ocultar completamente
}

// Llama a la función después de 216 segundos (216,000 milisegundos)
setTimeout(ocultarTitulo, 216000);