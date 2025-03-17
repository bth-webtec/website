// @ts-check
import { defineConfig } from 'astro/config';
import starlight from '@astrojs/starlight';

// https://astro.build/config
export default defineConfig({
	site: 'https://improved-winner-pr5gz4m.pages.github.io/',
	base: '',
	integrations: [
		starlight({
			title: 'Kursen webtec',
			logo: {
				src: './src/assets/leaf_256x256.png',
			},
			customCss: [
				'./src/styles/dbwebb.css',
			],
			social: {
				github: 'https://github.com/webtec-2024/website',
			},
			sidebar: [
				{
					label: 'Introduktion',
					autogenerate: { directory: 'intro' },
				},
				{
					label: 'Labbmiljö',
					autogenerate: { directory: 'labbmiljo' },
				},
				{
					label: 'Kursrepo',
					autogenerate: { directory: 'kursrepo' },
				},
				{
					label: 'Kursmoment',
					autogenerate: { directory: 'kmom' },
				},
				{
					label: 'Studieguide',
					autogenerate: { directory: 'studieguide' },
					/* items: [
						{ label: 'Example Guide', slug: 'guides/example' },
					],*/
				},
				{
					label: 'Reference',
					autogenerate: { directory: 'reference' },
				},
			],
		}),
	],
});
