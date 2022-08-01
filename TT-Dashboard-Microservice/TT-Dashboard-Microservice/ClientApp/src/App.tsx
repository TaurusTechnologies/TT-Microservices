import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Project from './components/Project';
import Counter from './components/Counter';

import './custom.css'

export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route exact path='/project/:id?' component={Project} />
        <Route path='/counter' component={Counter} />
    </Layout>
);
