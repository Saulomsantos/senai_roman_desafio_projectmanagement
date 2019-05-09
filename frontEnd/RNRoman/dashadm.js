import React, { Component } from 'react';
import { StyleSheet, Text, View, SafeAreaView, ScrollView, Dimensions, Image } from 'react-native';

import { createAppContainer, createDrawerNavigator, DrawerItems } from 'react-navigation';

import HomeAdm from './src/pages/homeadm';
import GerenciarTipoUsuario from './src/pages/gerenciartipousuario';
import Equipes from './src/pages/equipes';
import GerenciarUsuarios from './src/pages/gerenciarusuarios';
import CadastrarUsuario from './src/pages/cadastrarusuario';
import Temas from './src/pages/temas';
import HomePro from './src/pages/homepro';

const { width } = Dimensions.get('window')

export default class App extends Component {
    render() {
        return (
            <AppContainer />
        );
    }
}

const CustomDrawerComponent = (props) => (
    <SafeAreaView style={{flex:1}}>
        <View style={{height: 150, backgroundColor: 'white', alignItems: 'center', justifyContent: 'center'}}>
            <Image 
            source={require('./src/assets/imgs/rockstar_games_logo.png')}
            style={{height:100, width: 100, borderRadius: 60}}/>
        </View>
        <ScrollView>
            <DrawerItems {...props}/>
        </ScrollView>
    </SafeAreaView>
)

const AppDrawerNavigator = createDrawerNavigator({
    HomeAdm: HomeAdm,
    GerenciarTipoUsuario: GerenciarTipoUsuario,
    Equipes: Equipes,
    GerenciarUsuarios: GerenciarUsuarios,
    CadastrarUsuario: CadastrarUsuario,
    Temas: Temas,
    HomePro: HomePro
},{
    initialRouteName: 'HomeAdm',
    drawerWidth: 0.65 * width,
    contentComponent: CustomDrawerComponent,
    contentOptions: {
        activeTintColor: 'orange'
    },
}
)

const AppContainer = createAppContainer(AppDrawerNavigator);

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});