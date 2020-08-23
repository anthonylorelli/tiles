<script lang="ts">
	export let name: string;

	import Avett from './TheAvettBrothers.svelte';
	import Tile from './Tile.svelte';
	import type TheAvettBrothers from './TheAvettBrothers.svelte';
	import { onMount } from 'svelte';

	async function fetchTilesAsync()
	{
		const tilesUrl = 'https://api.tiles.local/Tiles';
		console.log(`fetching tiles from server: ${tilesUrl}`);
		const res = await fetch(tilesUrl);
		return await res.json();
	}

	let tiles: Array<Tile> = [];

	onMount(async () =>
	{
		tiles = await tilesPromise;
	});

	let tilesPromise = fetchTilesAsync();

</script>

<main>
	<h1>Many Tiles (fetched from the server)!</h1>

	{#await tilesPromise }
		<strong>Loading tiles...</strong>
	{:then}
		{#each tiles as tile }
			<div style="display:inline-block; margin: 10px;">
				<Tile topColor="gray" rightColor="lightBlue" bottomColor="red" leftColor="darkblue" />
				{tile.id}
			</div>
		{/each}
	{/await}
	
</main>

<style>
	main
	{
		padding: 1em;
		max-width: 240px;
		margin: 0 auto;
	}

	h1
	{
		color: #ff3e00;
		text-transform: uppercase;
		font-size: 2em;
		font-weight: 100;
	}

	@media (min-width: 640px)
	{
		main
		{
			max-width: none;
		}
	}
</style>