<template>
    <div class="flight-booking">
        <div class="search-bar">
            <input type="text" v-model="from" placeholder="From" />
            <input type="text" v-model="to" placeholder="To" />
            <input type="date" v-model="date" />
            <button @click="searchFlights" class="bg-red-500">
                <i class="fa fa-search"></i>
            </button>
        </div>
        <!-- Add your flight search results here -->
        <div class="flight-results">
            <div v-for="flight in searchResults" :key="flight.id" class="flight-result">
                <div class="flight-info">
                    <div class="flight-route">
                        <span>{{ flight.from }}</span>
                        <i class="fa fa-long-arrow-alt-right"></i>
                        <span>{{ flight.to }}</span>
                    </div>
                    <div class="flight-date">
                        <span>Date: {{ flight.date }}</span>
                    </div>
                    <div class="flight-price">
                        <span>Price: ${{ flight.price }}</span>
                    </div>
                </div>
                <button @click="bookFlight(flight.id)">Book Now</button>
            </div>
        </div>
    </div>
</template>

<script setup>
import { ref } from 'vue';

const from = ref('');
const to = ref('');
const date = ref('');
const searchResults = ref([]);

const searchFlights = () => {
    const flights = [
        { id: 1, from: 'New York', to: 'Los Angeles', date: '2022-10-01', price: 250 },
        { id: 2, from: 'London', to: 'Paris', date: '2022-09-15', price: 150 },
        { id: 3, from: 'Tokyo', to: 'Sydney', date: '2022-11-05', price: 500 }
    ];

    // Return the first 3 flights as search results
    searchResults.value = flights.slice(0, 3);
    return searchResults.value;
};

const bookFlight = (flightId) => {
    alert(`Flight with ID ${flightId} booked successfully!`);
};

</script>

<style scoped>
.flight-booking {
    /* Add your custom styles here */
}

.search-bar {
    display: flex;
    align-items: center;
    justify-content: space-between;
    padding: 10px;
    background-color: #f5f5f5;
    border-radius: 5px;
}

input[type='text'],
input[type='date'] {
    padding: 5px;
    border: none;
    outline: none;
    background-color: transparent;
    font-size: 14px;
}

button {
    padding: 5px;
    border: none;
    outline: none;
    background-color: transparent;
    cursor: pointer;
}
</style>