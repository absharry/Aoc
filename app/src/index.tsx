import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from "react-router-dom";
import 'bootstrap/dist/css/bootstrap.css';
import Layout from './components/layout';

ReactDOM.render(
    <BrowserRouter>
        <Layout />
    </BrowserRouter>, document.getElementById('root'));
