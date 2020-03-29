import React from 'react';
import './App.css';
import {store} from "./actions/store"
import {Provider} from "react-redux"
import Empleados from './components/Empleados';

function App() {
  return (
  <Provider store={store}>
    <Empleados/>
  </Provider>
  );
}

export default App;
