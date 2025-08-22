// @ts-check
import { defineConfig } from 'astro/config';
import { remarkReadingTime } from './src/plugins/remark-reading-time.mjs';
import starlight from '@astrojs/starlight';
import starlightImageZoom from 'starlight-image-zoom'

// https://astro.build/config
export default defineConfig({
	site: 'https://bth-webtec.github.io/website/',
	base: '/website',
	markdown: {
		remarkPlugins: [remarkReadingTime],
	},
	integrations: [
		starlight({
			plugins: [
				starlightImageZoom(),
			],
			title: 'Kursen webtec',
			favicon: 'favicon.png',
			logo: {
				//src: './src/assets/leaf_256x256.png',
				src: '@assets/leaf_256x256.png',
			},
			customCss: [
				'./src/styles/dbwebb.css',
			],
			editLink: {
				baseUrl: 'https://github.com/bth-webtec/website/tree/main',
			},
			social: {
				github: 'https://github.com/bth-webtec/website',
			},
			head: [
				{
				  tag: 'base',
				  attrs: {
					href: ''
				  }
				}
			],
			sidebar: [
				{
					label: 'Introduktion',
					collapsed: true,
					autogenerate: { directory: 'intro' },
				},
				{
					label: 'Kursmoment',
					autogenerate: { directory: 'kmom' },
				},
				{
					label: 'Läromaterial',
					collapsed: true,
					/* autogenerate: { directory: 'laromaterial' }, */
					items: [
						'laromaterial',
						{ 
							label: 'Labbmiljö',
							autogenerate: { directory: 'laromaterial/labbmiljo' },
							collapsed: true,
						},
						{ 
							label: 'Kursrepo',
							autogenerate: { directory: 'laromaterial/kursrepo' },
							collapsed: true,
						},
						{ 
							label: 'Kursrepo utvecklingsmiljö',
							autogenerate: { directory: 'laromaterial/kursrepo-utvecklingsmiljo' },
							collapsed: true,
						},
						{ 
							label: 'Föreläsning',
							autogenerate: { directory: 'laromaterial/forelasning' },
							collapsed: true,
						},
						{ 
							label: 'Övning',
							autogenerate: { directory: 'laromaterial/ovning' },
							collapsed: true,
						},
						{ 
							label: 'Lab',
							autogenerate: { directory: 'laromaterial/lab' },
							collapsed: true,
						},
						{ 
							label: 'Uppgift',
							autogenerate: { directory: 'laromaterial/uppgift' },
							collapsed: true,
						},
						{ 
							label: 'Instruktion',
							autogenerate: { directory: 'laromaterial/instruktion' },
							collapsed: true,
						},
					],
				},
				{
					label: 'Studieguide',
					collapsed: true,
					autogenerate: { directory: 'studieguide' },
					/* items: [
						{ label: 'Example Guide', slug: 'guides/example' },
					],*/
				},
				{
					label: 'Övrigt',
					collapsed: true,
					autogenerate: { directory: 'ovrigt' },
				},
			],
		}),
	],
});
