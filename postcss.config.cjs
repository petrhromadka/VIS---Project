const tailwindcss = require('tailwindcss');
const autoprefixer = require('autoprefixer');

const config = {
	darkMode: 'class',
	plugins: [
		// Některé pluginy, jako například tailwindcss/nesting, musí běžet před Tailwind,
		tailwindcss(),
		// Ale jiné, jako například autoprefixer, musí běžet po něm,
		autoprefixer
	]
};

module.exports = config;
